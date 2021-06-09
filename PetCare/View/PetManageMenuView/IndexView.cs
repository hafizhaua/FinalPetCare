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

			PetController.Index(CustID);

			Console.WriteLine("Option:");
			Console.WriteLine("\ta. Add pet");
			Console.WriteLine("\tb. See details");
			Console.WriteLine("\tc. Remove pet");
			Console.WriteLine("\td. Back");
			Console.Write("Input: ");
			string opt = Console.ReadLine().ToLower();

			PetManageMenuController.IndexOption(CustID, opt);
		}

		public static void Failed()
        {
			ColoredText.Red("Input is invalid.");
		}
    }
}
