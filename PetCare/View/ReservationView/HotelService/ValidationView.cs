using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.ReservationView.HotelService
{
    public static class ValidationView
    {
        public static void Show(Reservation rsv)
        {
            Console.WriteLine($"You plan to reserve {rsv.Period} day(s) of pet boarding for IDR {rsv.Price}");
            Console.Write("Proceed? (y/n) ");
            bool val = checkInput();
            PetHotelServiceController.Validate(val, rsv);
        }

        public static bool checkInput()
        {
            if (Console.ReadLine().ToLower() == "y") return true;
            else return false;
        }
    }
}
