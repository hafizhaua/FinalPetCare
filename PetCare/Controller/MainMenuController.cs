using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.View.MainMenuView;

namespace PetCare
{
	public static class MainMenuController
	{
		public static void Index(int CustID)
		{
            using var db = new AppPetCareContext();
            string name = db.Customers
                    .FirstOrDefault(cust => cust.CustomerID == CustID).Username;
            IndexView.Show(CustID, name);
        }

        public static void IndexOption(int CustID, string opt)
        {

            if (opt == "1")
            {
                PetManageMenuController.Index(CustID);
            }
            else if (opt == "2")
            {
                ReservationManageMenuController.Index(CustID);
            }
            else if (opt == "3")
            {
                ReservationController.Index(CustID);
            }
            else if (opt == "4")
            {
                IndexView.LogOut();
                Exit.Now();
                LoginController.Index();
            }
            else
            {
                IndexView.Failed();
            }
        }
	}
}
