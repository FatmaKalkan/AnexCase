namespace AnexCase
{
    partial class frmAnexCase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnexCase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportToData = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gc_AnexCase = new DevExpress.XtraGrid.GridControl();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv_AnexCase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReservationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHotel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHotelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsHotelName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ds_AnexCase = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AnexCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AnexCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsHotelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportToData);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 44);
            this.panel1.TabIndex = 4;
            // 
            // btnExportToData
            // 
            this.btnExportToData.Enabled = false;
            this.btnExportToData.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportToData.ImageOptions.SvgImage")));
            this.btnExportToData.Location = new System.Drawing.Point(137, 3);
            this.btnExportToData.Name = "btnExportToData";
            this.btnExportToData.Size = new System.Drawing.Size(145, 38);
            this.btnExportToData.TabIndex = 1;
            this.btnExportToData.Text = "Seçili Olanları Aktar";
            this.btnExportToData.Click += new System.EventHandler(this.btnExportToData_Click);
            // 
            // btnImport
            // 
            this.btnImport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImport.ImageOptions.SvgImage")));
            this.btnImport.Location = new System.Drawing.Point(12, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(119, 38);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Excelden Oku";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gc_AnexCase);
            this.panel2.Location = new System.Drawing.Point(10, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 376);
            this.panel2.TabIndex = 5;
            // 
            // gc_AnexCase
            // 
            this.gc_AnexCase.DataSource = this.reservationBindingSource;
            this.gc_AnexCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_AnexCase.Location = new System.Drawing.Point(0, 0);
            this.gc_AnexCase.MainView = this.gv_AnexCase;
            this.gc_AnexCase.Name = "gc_AnexCase";
            this.gc_AnexCase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpsHotelName});
            this.gc_AnexCase.Size = new System.Drawing.Size(775, 376);
            this.gc_AnexCase.TabIndex = 0;
            this.gc_AnexCase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_AnexCase});
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(AnexCase.Models.Reservation);
            // 
            // gv_AnexCase
            // 
            this.gv_AnexCase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReservationNo,
            this.colCreateDate,
            this.colPax,
            this.colHotel,
            this.colHotelName});
            this.gv_AnexCase.GridControl = this.gc_AnexCase;
            this.gv_AnexCase.Name = "gv_AnexCase";
            this.gv_AnexCase.OptionsBehavior.Editable = false;
            this.gv_AnexCase.OptionsSelection.MultiSelect = true;
            this.gv_AnexCase.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_AnexCase.OptionsView.ColumnAutoWidth = false;
            this.gv_AnexCase.OptionsView.ShowFooter = true;
            this.gv_AnexCase.OptionsView.ShowGroupPanel = false;
            // 
            // colReservationNo
            // 
            this.colReservationNo.FieldName = "ReservationNo";
            this.colReservationNo.Name = "colReservationNo";
            this.colReservationNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ReservationNo", "Row Count={0}")});
            this.colReservationNo.Visible = true;
            this.colReservationNo.VisibleIndex = 1;
            this.colReservationNo.Width = 93;
            // 
            // colCreateDate
            // 
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 2;
            // 
            // colPax
            // 
            this.colPax.FieldName = "Pax";
            this.colPax.Name = "colPax";
            this.colPax.Visible = true;
            this.colPax.VisibleIndex = 3;
            // 
            // colHotel
            // 
            this.colHotel.FieldName = "Hotel";
            this.colHotel.Name = "colHotel";
            this.colHotel.Visible = true;
            this.colHotel.VisibleIndex = 4;
            // 
            // colHotelName
            // 
            this.colHotelName.Caption = "HotelName";
            this.colHotelName.ColumnEdit = this.rpsHotelName;
            this.colHotelName.FieldName = "Name";
            this.colHotelName.Name = "colHotelName";
            this.colHotelName.UnboundDataType = typeof(int);
            this.colHotelName.UnboundExpression = "[Hotel]";
            this.colHotelName.Visible = true;
            this.colHotelName.VisibleIndex = 5;
            this.colHotelName.Width = 147;
            // 
            // rpsHotelName
            // 
            this.rpsHotelName.AutoHeight = false;
            this.rpsHotelName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsHotelName.DataSource = this.hotelBindingSource;
            this.rpsHotelName.DisplayMember = "Name";
            this.rpsHotelName.KeyMember = "Id";
            this.rpsHotelName.Name = "rpsHotelName";
            this.rpsHotelName.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.rpsHotelName.ValueMember = "Id";
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(AnexCase.Models.Hotel);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ds_AnexCase
            // 
            this.ds_AnexCase.Name = "ds_AnexCase";
            // 
            // frmAnexCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(801, 483);
            this.MinimumSize = new System.Drawing.Size(801, 483);
            this.Name = "frmAnexCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnexCase";
            this.Load += new System.EventHandler(this.frmAnexCase_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_AnexCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AnexCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsHotelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnExportToData;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gc_AnexCase;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_AnexCase;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colReservationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPax;
        private DevExpress.XtraGrid.Columns.GridColumn colHotel;
        private DevExpress.XtraGrid.Columns.GridColumn colHotelName;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpsHotelName;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.DataAccess.Excel.ExcelDataSource ds_AnexCase;
    }
}