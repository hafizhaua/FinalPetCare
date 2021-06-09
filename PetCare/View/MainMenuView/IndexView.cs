using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.MainMenuView
{
    public static class IndexView
    {
		public static void Show(int CustID, string name)
		{
            Console.Clear();
            Console.WriteLine("=========== PET CARE ==========");
            Console.WriteLine($"Welcome to Pet Care, {name}!");
            Console.WriteLine("Choose a menu:");
            Console.WriteLine("\t1. Your Pet List");
            Console.WriteLine("\t2. Reserve a Place");
            Console.WriteLine("\t3. See Reservation");
            Console.WriteLine("\t4. Log Out");

            Console.Write("Input: ");
            string opt = Console.ReadLine();
            Console.WriteLine();

            MainMenuController.IndexOption(CustID, opt);
		}

		public static void Failed()
		{
            ColoredText.Red("Input is invalid.");
        }

        public static void LogOut()
        {
            ColoredText.Yellow("See you again! :)");
        }
	}
}
