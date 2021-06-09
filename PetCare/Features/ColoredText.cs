using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public static class ColoredText
    {
        public static void Red(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(s);
            Console.WriteLine("Press ENTER to back ..");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void Yellow(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(); 
            Console.WriteLine(s);
            Console.WriteLine("Press ENTER to continue ..");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void Green(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(s);
            Console.WriteLine("Press ENTER to continue ..");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void Blue(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine(s);
            Console.WriteLine("Press ENTER to continue ..");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
