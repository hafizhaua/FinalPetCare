using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.PetManageMenuView
{
    public class IndexView
    {
        public static void Show(int CustID)
        {
			Console.Clear();
			Console.WriteLine("== Manage Pet List =========");

			PrintTable(CustID);

			ShowOption();
			Console.Write("Input: ");
			string opt = Console.ReadLine().ToLower();

			PetManageMenuController petManageMenu = new();
			petManageMenu.Index(CustID, opt);
		}

		private static void PrintTable(int CustID)
        {
            PetController.Index(CustID);
		}

		private static void ShowOption()
        {
			Console.WriteLine("Option:");
			Console.WriteLine("\ta. Add pet");
			Console.WriteLine("\tb. See details");
			Console.WriteLine("\tc. Remove pet");
			Console.WriteLine("\td. Back");
		}

		public static void Failed()
        {
			ColoredText.Red("Input is invalid.");
		}
    }
}
