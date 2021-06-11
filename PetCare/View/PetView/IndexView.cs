using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.PetView
{
    public static class IndexView
    {
        public static void Show(IQueryable<Pet> list)
        {
			int count = list.Count();

            switch (count)
            {
                case 0:
                    Console.WriteLine("Your list is empty.");
                    break;
                default:
                    Console.WriteLine("\nYou have {0} pet(s) on the list!", count);
                    break;
            }

            FillTable(list);
		}

        private static void FillTable(IQueryable<Pet> list)
        {
            Console.WriteLine("+---------+--------+--------+");
            Console.WriteLine("| Name    | Animal | ID     |");
            Console.WriteLine("+---------+--------+--------+");
            foreach (var pet in list)
            {
                Console.Write($"| {pet.Name,7} | {pet.Animal,6} | {pet.PetID,6} |\n");
            }
            Console.WriteLine("+---------+--------+--------+");
        }
    }
}
