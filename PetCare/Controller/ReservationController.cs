using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.Entities;
using PetCare.View.ReservationView;

namespace PetCare
{
    public class ReservationController
    {
        public static void Index(int CustID)
        {
            using var db = new AppPetCareContext();
            var reservationList = db.Reservations.Where(res => res.CustomerID == CustID);
            if (reservationList != null)
            {
                IndexView.Show(reservationList);
            }
            MainMenuController mainMenuController = new();
            mainMenuController.Index(CustID);
        }

        public static void Add(int CustID, int PetID)
        {
            using (var db = new AppPetCareContext())
            {
                Pet pet = db.Pet.FirstOrDefault(pet => pet.CustomerID == CustID && pet.PetID == PetID);
                
                if(pet != default)
                {
                    AddView.Show(CustID, pet);
                }
            }
        }

        public static void PickService(string opt, Pet pet)
        {
            if (opt == "1" || opt == "pet hotel")
            {
                PetHotelServiceController petHotelService = new();
                petHotelService.Index(pet);
            }
            else
            {
                ColoredText.Red("Invalid option.");
            }
        }

        public static void Add(Reservation rsv)
        {
            using var context = new AppPetCareContext();
            if (rsv != null)
            {
                context.Reservations.Add(rsv);
                context.SaveChanges();
                AddView.Success();
            }
            else
            {
                AddView.Failed();
            }
        }
    }
}
