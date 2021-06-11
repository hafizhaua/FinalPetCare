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

            ReservationManageMenuController reservationManageMenu = new();
            reservationManageMenu.Index(CustID, opt);
        }

        private static void PrintMenu()
        {
            Console.WriteLine(
                "Select pet for the services:\n" +
                "\ta. Select from the menu\n" +
                "\tb. Register another pet\n" +
                "\tc. Back");
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
