using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.ReservationManageMenuView
{
    public static class IndexView
    {
        public static void Show(int CustID)
        {
            Console.Clear();
            Console.WriteLine("== Pet Care Reservation =========");

            PrintList(CustID);

            PrintMenu();

            Console.Write("Input: ");
            string opt = Console.ReadLine().ToLower();

            ReservationManageMenuController.Index(CustID, opt);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Select pet for the services:");
            Console.WriteLine("\ta. Select from the menu");
            Console.WriteLine("\tb. Register another pet");
            Console.WriteLine("\tc. Back");
        }

        public static void Failed()
        {
            ColoredText.Red("Input is invalid.");
        }

        private static void PrintList(int CustID)
        {
            PetController.Index(CustID);
        }
    }
}
