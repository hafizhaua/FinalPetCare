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
            EnterBackMessage(s);
        }

        public static void Yellow(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            EnterContinueMessage(s);
        }

        public static void Green(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            EnterContinueMessage(s);
        }

        private static void EnterContinueMessage(string s)
        {
            Console.WriteLine($"\n{s}");
            Console.WriteLine("Press ENTER to continue ..");
            ResetColor();
        }

        private static void EnterBackMessage(string s)
        {
            Console.WriteLine($"\n{s}");
            Console.WriteLine("Press ENTER to back ..");
            ResetColor();
        }

        private static void ResetColor()
        {
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
