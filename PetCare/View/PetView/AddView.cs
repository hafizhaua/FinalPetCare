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
			Console.Write("Select the type of your animal:\n" +
				"\t1. Dog\n" +
				"\t2. Cat\n" +
				"Input: ");
			pet.Animal = GetAnimal(ref isValid);
			if (!isValid) return;
			
			// Name
			Console.Write("Name (max 7 letters): ");
			pet.Name = GetName(ref isValid);
			if (!isValid) return;

			// Sex
			Console.Write("Sex (Male/Female): ");
			pet.Sex = GetSex(ref isValid);
			if (!isValid) return;

			// Weight
			Console.Write("Weight (kg): ");
			pet.Weight = GetWeight(ref isValid);
			if (!isValid) return;

            PetController.Add(pet, isValid);
		}

		private static string GetAnimal(ref bool isValid)
        {
			string animal = Console.ReadLine().ToLower();
			if (animal == "1" || animal == "dog")
			{
				animal = "Dog";
			}
			else if (animal == "2" || animal == "cat")
			{
				animal = "Cat";
			}
			else
			{
				ColoredText.Red("Input is invalid.");
				isValid = false;
			}

			return animal;
		}

		private static string GetName(ref bool isValid)
        {
			string name = Console.ReadLine();
			if (name.Length > 7)
			{
				ColoredText.Red("Name is too long. terminating process..");
				isValid = false;
				return "";
			}
			return name;
		}

		private static string GetSex(ref bool isValid)
        {
			string sex = Console.ReadLine().ToLower();
			if (sex != "male" && sex != "female")
			{
				ColoredText.Red($"Sex '{sex}' is invalid.");
				isValid = false;
				return "";
			}
			return sex;
		}

		private static double GetWeight(ref bool isValid)
        {
			double weight;
			try
			{
				weight = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception e)
			{
				ColoredText.Red(e.Message);
				isValid = false;
				weight = 0;
			}
			return weight;
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
