using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.Entities;
using PetCare.View.LoginView;

namespace PetCare
{
    public static class LoginController
    {
        public static void Index()
        {
            IndexView.Show();
        }

        public static void Index(string uname, string pass)
        {
            int LoginID = Validate(uname, pass);
            if (LoginID >= 0)
            {
                IndexView.Success();
                MainMenuController.Index(LoginID);
            }
            else
            {
                IndexView.Failed();
                Exit.Now();
                Index();
            }
        }

        public static int Validate(string uname, string pass)
        {
            using var db = new AppPetCareContext();
            if (db.Customers.Where(cust => cust.Username == uname && cust.Password == pass).Any())
            {
                int AccID = db.Customers
                    .FirstOrDefault(cust => cust.Username == uname && cust.Password == pass).CustomerID;
                return AccID;
            }
            else return -1;
        }
    }
}
