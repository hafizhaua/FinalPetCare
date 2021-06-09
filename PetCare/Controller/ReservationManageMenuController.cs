using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.Entities;
using PetCare.View.ReservationManageMenuView;

namespace PetCare
{
    public static class ReservationManageMenuController
    {

        public static void Index(int CustID)
        {
            IndexView.Show(CustID);
        }

        public static void Index(int CustID, string opt)
        {

            if (opt == "a")
            {
                Select(CustID);
                Index(CustID);
            }
            else if (opt == "b")
            {
                PetController.Add(CustID);
                Index(CustID);
            }
            else if (opt == "c")
            {
                MainMenuController.Index(CustID);
            }
            else
            {
                IndexView.Failed();
                Index(CustID);
            }
        }

        public static void Select(int CustID)
        {
            SelectView.Show(CustID);
        }

        public static void Select(int SelectionID, int CustID)
        {
            using (var db = new AppPetCareContext())
            {
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
}
