using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.Entities
{
    public static class PetHotelService
    {
        private static int CalculatePricePerDay(double weight)
        {
            int scale = Convert.ToInt32(weight) / 5;
            int price = 70000 + scale * 25000;
            return price;
        }

        public static int CalculateTotal(int days, double weight)
        {
            int price = CalculatePricePerDay(weight) * days;
            return price;
        }
    }
}
