using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.Entities;
using PetCare.View.ReservationManageMenuView;

namespace PetCare
{
    public class ReservationManageMenuController : IMenuController
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
                    Select(CustID);
                    Index(CustID);
                    break;
                case "b":
                    PetController.Add(CustID);
                    Index(CustID);
                    break;
                case "c":
                    MainMenuController mainMenuController = new();
                    mainMenuController.Index(CustID);
                    break;
                default:
                    IndexView.Failed();
                    Index(CustID);
                    break;
            }
        }

        public static void Select(int CustID)
        {
            SelectView.Show(CustID);
        }

        public static void Select(int SelectionID, int CustID)
        {
            using var db = new AppPetCareContext();
            bool exist = db.Pet.Where(pet => pet.CustomerID == CustID && pet.PetID == SelectionID).Any();

            if (exist)
            {
                ReservationController.Add(CustID, SelectionID);
            }
            else
            {
                SelectView.Failed();
            }
        }


    }
}
