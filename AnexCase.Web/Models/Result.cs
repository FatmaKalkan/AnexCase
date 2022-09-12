using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnexCase.Web.Models
{
    [Table("Result")]
    public class Result
    {
        public int Id { get; set; } 
        public int? Hoteld { get; set; } = 0;
        public string? HotelName { get; set; }
        public DateTime Date { get; set; }
        public int? TotalPax { get; set; } = 0;
        public string? ReservationNumber { get; set; }

    }
}
