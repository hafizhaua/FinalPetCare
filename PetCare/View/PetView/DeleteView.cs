using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.PetView
{
    class DeleteView
    {
        public static void Show(int CustID, int count)
        {
            if (count > 0)
            {
                Console.Write($"Input pet ID : ");
                int PetRemoveID = Convert.ToInt32(Console.ReadLine());
                PetController.Delete(CustID, PetRemoveID);
            }
            else
            {
                Console.WriteLine("List is empty.");
            }
            Console.WriteLine();
        }

        public static void Success(string name)
        {
            ColoredText.Yellow($"Bye-bye {name}..");
        }

        public static void Failed()
        {
            ColoredText.Red("Failed to remove.");
        }
    }
}
