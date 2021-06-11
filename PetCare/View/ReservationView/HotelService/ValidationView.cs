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
            bool val = CheckInput();

            PetHotelServiceController petHotelService = new();
            petHotelService.ValidateUser(val, rsv);
        }

        public static bool CheckInput()
        {
            if (Console.ReadLine().ToLower() == "y") return true;
            else return false;
        }

        public static void InvalidDate()
        {
            ColoredText.Red("Invalid date.");
        }

        public static void UserDeclined()
        {
            ColoredText.Yellow("Reservation canceled.");
        }
    }
}
