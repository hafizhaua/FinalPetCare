using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.View.PetManageMenuView;

namespace PetCare
{
    public static class PetManageMenuController
    {
        public static void Index(int CustID)
        {
            IndexView.Show(CustID);
        }

        public static void IndexOption(int CustID, string opt)
        {
			if (opt == "a")
			{
				PetController.Add(CustID);
				Index(CustID);
			}
			else if (opt == "b")
			{
				PetController.Detail(CustID);
				Index(CustID);
			}
			else if (opt == "c")
			{
				PetController.Delete(CustID);
				Index(CustID);
			}
			else if (opt == "d")
			{
				Console.WriteLine();
				MainMenuController.Index(CustID);
			}
			else
			{
				IndexView.Failed();
				Index(CustID);
			}
		}
    }
}
