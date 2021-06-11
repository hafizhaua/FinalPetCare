using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.ReservationView.HotelService
{
    public static class IndexView
    {
        public static int GetPeriod()
        {
            DateTime startDate, endDate;

            Console.Write("\nEnter start date (MM/DD/YY): ");
            startDate = GetDate();

            Console.Write("Enter pickup date (MM/DD/YY): ");
            endDate = GetDate();

            return (endDate - startDate).Days;
        }

        private static DateTime GetDate()
        {
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date) || date < DateTime.Today)
            {
                ColoredText.Red("Invalid value. Set to today's instead.");
                date = DateTime.Today;
            }
            return date;
        }
    }
}
