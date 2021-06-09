using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
