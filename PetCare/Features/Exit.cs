using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public static class Exit
    {
        public static void Now()
        {
            Console.Write("Do you want to exit? (y/n) ");
            string exit = Console.ReadLine().ToLower();
            if (exit == "y") Environment.Exit(1);
        }
    }
}
