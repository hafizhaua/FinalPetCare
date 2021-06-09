using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.ReservationView
{
    public static class AddView
    {
        public static void Show(int CustID, Pet pet)
        {
            Console.Clear();
            PrintHeader(pet.Name);

            pet.ShowPetDetail();

            PrintMenu();

            Console.Write("Input: ");
            string opt = Console.ReadLine().ToLower();

            ReservationController.PickService(opt, pet);
        }

        private static void PrintHeader(string name)
        {
            Console.WriteLine("~~~~ Pet Reservation Form ~~~~");
            Console.WriteLine($"\n{name}'s biodata:");
        }

        private static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select our services:");
            Console.WriteLine($"    1. Pet Hotel"); 
        }

        internal static void Success()
        {
            ColoredText.Yellow("Reservation reserved successfully");
        }

        internal static void Failed()
        {
            ColoredText.Red("Reservation failed.");
        }
    }
}
