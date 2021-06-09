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
        public static int getPeriod()
        {
            DateTime startDate, endDate;
            DateTime now = DateTime.Today;

            Console.Write("\nEnter start date (MM/DD/YY): ");
            startDate = getDate();

            Console.Write("Enter pickup date (MM/DD/YY): ");
            endDate = getDate();

            return (endDate - startDate).Days;
        }

        private static DateTime getDate()
        {
            DateTime date;
            if (!DateTime.TryParse(Console.ReadLine(), out date) || date < DateTime.Today)
            {
                ColoredText.Red("Invalid value. Set to today's instead.");
                date = DateTime.Today;
            }
            return date;
        }
    }
}
