using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.Entities
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public string Services { get; set; }
        public int Price { get; set; }
        public int Period { get; set; }
        public int CustomerID { get; set; }
        public int PetID { get; set; }
    }
}
