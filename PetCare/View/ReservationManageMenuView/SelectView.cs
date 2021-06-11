using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.ReservationManageMenuView
{
    public class SelectView
    {
        public static void Show(int CustID)
        {
            try
            {
                Console.Write("Input the ID of the pet: ");
                int idSelection = Convert.ToInt32(Console.ReadLine());

                ReservationManageMenuController reservationManageMenu = new();
                ReservationManageMenuController.Select(idSelection, CustID);
            }
            catch(Exception e)
            {
                ColoredText.Red(e.Message);
            }
            
        }

        public static void Failed()
        {
            ColoredText.Red("Input is invalid.");
        }
    }
}
