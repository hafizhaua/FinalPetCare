using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.View.PetManageMenuView;

namespace PetCare
{
    public class PetManageMenuController : IMenuController
    {
        public void Index(int CustID)
        {
            IndexView.Show(CustID);
        }

        public void Index(int CustID, string opt)
        {

            switch (opt)
            {
                case "a":
                    PetController.Add(CustID);
                    Index(CustID);
                    break;
                case "b":
                    PetController.Detail(CustID);
                    Index(CustID);
                    break;
                case "c":
                    PetController.Delete(CustID);
                    Index(CustID);
                    break;
                case "d":
                    Console.WriteLine();
                    MainMenuController mainMenuController = new();
                    mainMenuController.Index(CustID);
                    break;
                default:
                    IndexView.Failed();
                    Index(CustID);
                    break;
            }
        }
    }
}
