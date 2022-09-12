using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnexCase.Models
{
    [Table("Result")]
    public class Result
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int Hoteld { get; set; }
        public string HotelName { get; set; }
        public DateTime Date { get; set; }
        public int? TotalPax { get; set; } = 0;
        public string ReservationNumber { get; set; }

    }
}
