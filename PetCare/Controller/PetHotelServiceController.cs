using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.View.ReservationView.HotelService;

namespace PetCare
{
    public static class PetHotelServiceController
    {
        public static void Index(Pet pet)
        {
            var rsv = new Reservation
            {
                Services = "Hotel",
                CustomerID = pet.CustomerID,
                PetID = pet.PetID
            };

            rsv.Period = IndexView.getPeriod();
            rsv.Price = PetHotelService.CalculateTotal(rsv.Period, pet.Weight);

            Validate(rsv);
        }

        public static void Validate(Reservation rsv)
        {
            if (rsv.Period > 0)
            {
                ValidationView.Show(rsv);
            }
            else
            {
                ColoredText.Red("Invalid date.");
            }
        }

        public static void Validate(bool val, Reservation rsv)
        {
            if (val) 
            {
                ReservationController.Add(rsv);
            }
            else
            {
                ColoredText.Yellow("Reservation canceled.");
            }
        }
    }
}
