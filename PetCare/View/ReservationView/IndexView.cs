using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.ReservationView
{
    class IndexView
    {
        public static void Show(IQueryable<Reservation> reservationList)
        {
            Console.Clear();
            PrintHeader();
            int sum = 0;

            sum = PrintTableContent(reservationList, sum);

            PrintFooter(sum);

            ColoredText.Yellow("If your pet has been showed up above, you can bring it to our store, thank you!");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("======= Your Reservation =======\n");
            Console.WriteLine("+--------+-----------+--------+----------+");
            Console.WriteLine("| PetID  |  Service  | RsrvID | Price    |");
            Console.WriteLine("+--------+-----------+--------+----------+");
        }

        private static int PrintTableContent(IQueryable<Reservation> reservationList, int sum)
        {
            foreach (var item in reservationList)
            {
                Console.Write($"| {item.PetID,6} | {item.Services,9} | {item.ReservationID,6} | {item.Price,8} |\n");
                sum += item.Price;
            }
            return sum;
        }

        private static void PrintFooter(int sum)
        {
            Console.WriteLine("+--------+-----------+--------+----------+");
            Console.WriteLine($"                     | Total IDR {sum,7} |");
            Console.WriteLine("                     +-------------------+");
        }
    }
}
