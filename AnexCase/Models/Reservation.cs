using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnexCase.Models
{
    public class Reservation
    {
        public string ReservationNo { get; set; }
        public DateTime CreateDate { get; set; }
        public int? Pax { get; set; } = 0;
        public int? Hotel { get; set; } = 0;

    }
}
