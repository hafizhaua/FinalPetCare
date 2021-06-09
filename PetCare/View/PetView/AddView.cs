using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.Entities;

namespace PetCare.View.PetView
{
    public static class AddView
    {
        public static void Show(int CustID)
        {
			Console.Clear();

			Pet pet = new()
            {
				CustomerID = CustID
			};

			bool isValid = true;

			Console.WriteLine("==== Pet Registration Form ====");

			// Animal Type
			Console.WriteLine("Select the type of your animal:");
			Console.WriteLine("\t1. Dog");
			Console.WriteLine("\t2. Cat");
			Console.Write("Input: ");
			string animal = Console.ReadLine().ToLower();
			if (animal == "1" || animal == "dog")
			{
				pet.Animal = "Dog";
			}
			else if (animal == "2" || animal == "cat")
			{
				pet.Animal = "Cat";
			}
			else
			{
				ColoredText.Red("Input is invalid.");
				isValid = false;
				return;
			}

			// Name
			Console.Write("Name (max 7 letters): ");
			pet.Name = Console.ReadLine();
			if (pet.Name.Length > 7)
			{
				ColoredText.Red("Name is too long. terminating process..");
				isValid = false;
				return;
			}

			// Sex
			Console.Write("Sex (Male/Female): ");
			pet.Sex = Console.ReadLine().ToLower();
			if (pet.Sex != "male" && pet.Sex != "female")
			{
				ColoredText.Red($"Sex '{pet.Sex}' is invalid.");
				isValid = false;
				return;
			}

			// Weight
			Console.Write("Weight (kg): ");
			try
			{
				pet.Weight = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception e)
			{
				ColoredText.Red(e.Message);
				isValid = false;
				return;
			}

			PetController.Add(pet, isValid);
		}

		public static void Success()
        {
			ColoredText.Yellow("Your pet has been successfully added!");
		}

		public static void Failed()
        {
			ColoredText.Red("Your pet failed to be registered.");
        }
    }
}
