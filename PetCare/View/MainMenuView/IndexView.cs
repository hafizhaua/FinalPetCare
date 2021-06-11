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
            
            PrintMenu();

            Console.Write("Input: ");
            string opt = Console.ReadLine();
            Console.WriteLine();

            MainMenuController mainMenuController = new();
            mainMenuController.Index(CustID, opt);
		}

        private static void PrintMenu()
        {
            Console.WriteLine(
                "Choose a menu:\n" +
                "\t1. Your Pet List\n" +
                "\t2. Reserve a Place\n" +
                "\t3. See Reservation\n" +
                "\t4. Log Out"
            );
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
