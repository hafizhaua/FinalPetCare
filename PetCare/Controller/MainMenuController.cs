using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.View.MainMenuView;

namespace PetCare
{
	public class MainMenuController : IMenuController
	{
		public void Index(int CustID)
		{
            using var db = new AppPetCareContext();
            string name = db.Customers
                    .FirstOrDefault(cust => cust.CustomerID == CustID).Username;
            IndexView.Show(CustID, name);
        }

        public void Index(int CustID, string opt)
        {
            switch (opt)
            {
                case "1":
                    PetManageMenuController petManageMenu = new();
                    petManageMenu.Index(CustID);
                    break;
                case "2":
                    ReservationManageMenuController reservationManageMenu = new();
                    reservationManageMenu.Index(CustID);
                    break;
                case "3":
                    ReservationController.Index(CustID);
                    break;
                case "4":
                    IndexView.LogOut();
                    Exit.Now();
                    LoginController.Index();
                    break;
                default:
                    IndexView.Failed();
                    Index(CustID);
                    break;
            }
        }
	}
}
