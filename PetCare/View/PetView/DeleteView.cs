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
            switch (count)
            {
                case 0:
                    Console.WriteLine("List is empty.");
                    break;
                default:
                    Console.Write($"Input pet ID : ");
                    try
                    {
                        int PetRemoveID = Convert.ToInt32(Console.ReadLine());
                        PetController.Delete(CustID, PetRemoveID);
                    }
                    catch (Exception e)
                    {
                        ColoredText.Red(e.Message);
                        PetManageMenuController petManageMenu = new();
                        petManageMenu.Index(CustID);
                    }
                    break;
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
