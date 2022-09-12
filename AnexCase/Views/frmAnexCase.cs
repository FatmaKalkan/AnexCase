using AnexCase.Context;
using AnexCase.Models;
using DevExpress.DataAccess.Excel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnexCase
{
    public partial class frmAnexCase : DevExpress.XtraEditors.XtraForm
    {
        public frmAnexCase()
        {
            InitializeComponent();
        }

        AnexCaseContext db = new AnexCaseContext();
        List<Result> listresultgroup = new List<Result>();
        List<Hotel> hotels = null;
        string file = "1.xlsx";
        private void frmAnexCase_Load(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            HotelRead();
            ReadExcelToGrid();
        }

        private void btnExportToData_Click(object sender, EventArgs e)
        {
            try
            {
                int[] RowHandles = gv_AnexCase.GetSelectedRows();
                if (RowHandles.Length < 1)
                {
                    XtraMessageBox.Show("Lütfen Aktarılacak Satırları Seçiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var selecetedrows = gv_AnexCase.GetSelectedRows();
                    listresultgroup.Clear();
                    foreach (var handle in selecetedrows)
                    {
                        Result mt = new Result
                        {
                            Hoteld = Convert.ToInt32(gv_AnexCase.GetRowCellValue(handle, colHotel)),
                            HotelName = gv_AnexCase.GetRowCellDisplayText(handle, colHotelName).ToString(),
                            Date = Convert.ToDateTime(gv_AnexCase.GetRowCellValue(handle, colCreateDate)),
                            TotalPax = Convert.ToInt32(gv_AnexCase.GetRowCellValue(handle, colPax)),
                            ReservationNumber = Convert.ToString(gv_AnexCase.GetRowCellValue(handle, colReservationNo))
                        };
                        listresultgroup.Add(mt);
                    }
                    var consolidatedResult =
                        listresultgroup
                            .GroupBy(c => new
                            {
                                c.Date,
                                c.Hoteld,
                                c.HotelName
                            })
                            .Select(gcs => new Result()
                            {
                                Date = gcs.Key.Date,
                                Hoteld = gcs.Key.Hoteld,
                                TotalPax = gcs.Sum(c => c.TotalPax),
                                ReservationNumber = string.Join(";", gcs.Select(i => i.ReservationNumber)),
                                HotelName = gcs.Key.HotelName,
                            });


                    foreach (var item in consolidatedResult)
                    {
                        db.Results.Add(item);
                        db.SaveChanges();
                    }
                    XtraMessageBox.Show("Aktarılmıştır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Aktarım sırasında sorun ile karşılaşıldı. {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReadExcelToGrid()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Dosya Seçin";
                openFileDialog.Filter = "Excel(*.xlsx)|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file = openFileDialog.FileName;
                    ExcelDataSource excelData = new ExcelDataSource();
                    excelData.FileName = file;
                    ExcelWorksheetSettings sheetSettings = new ExcelWorksheetSettings("Data");
                    excelData.SourceOptions = new ExcelSourceOptions(sheetSettings);
                    excelData.SourceOptions = new CsvSourceOptions();
                    excelData.SourceOptions.SkipEmptyRows = false;
                    excelData.SourceOptions.UseFirstRowAsHeader = true;
                    excelData.Fill();
                    if (excelData != null)
                        btnExportToData.Enabled = true;
                    gc_AnexCase.DataSource = excelData;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Aktarım sırasında sorun ile karşılaşıldı. {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void HotelRead()
        {
            try
            {
                AnexCaseContext context = new AnexCaseContext();
                hotels = context.Hotels.ToList();
                rpsHotelName.DataSource = hotels;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Aktarım sırasında sorun ile karşılaşıldı. {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}