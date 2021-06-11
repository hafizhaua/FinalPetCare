using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.View.ReservationView.HotelService;

namespace PetCare
{
    public class PetHotelServiceController : IServiceController
    {
        public void Index(Pet pet)
        {
            var rsv = new Reservation
            {
                Services = "Hotel",
                CustomerID = pet.CustomerID,
                PetID = pet.PetID
            };

            rsv.Period = IndexView.GetPeriod();
            rsv.Price = PetHotelService.CalculateTotal(rsv.Period, pet.Weight);

            ValidatePeriod(rsv);
        }

        private static void ValidatePeriod(Reservation rsv)
        {
            if (rsv.Period > 0)
            {
                ValidationView.Show(rsv);
            }
            else
            {
                ValidationView.InvalidDate();
            }
        }

        public void ValidateUser(bool val, Reservation rsv)
        {
            if (val) 
            {
                ReservationController.Add(rsv);
            }
            else
            {
                ValidationView.UserDeclined();
            }
        }
    }
}
