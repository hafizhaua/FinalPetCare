using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.Entities;

namespace PetCare.View.PetView
{
    public static class DetailView
    {
        public static void Show(int CustID, int count)
        {
            if (count > 0)
            {
                Console.Write($"Input pet ID: ");
                int PetDetailID = Convert.ToInt32(Console.ReadLine());
                PetController.Detail(CustID, PetDetailID);
            }
            else
            {
                ColoredText.Yellow("List is empty.");
            }
            Console.WriteLine();
        }

		public static void Success(Pet pet)
        {
            pet.ShowPetDetail();
            ColoredText.Yellow("There you go.");
		}

		public static void Failed()
        {
            ColoredText.Red("Inputted ID is invalid! Failed to show the details.");
        }
    }
}
