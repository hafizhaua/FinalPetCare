using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.View.LoginView
{
    public static class IndexView
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Pet Care!");
            Console.WriteLine("Please log in to your account.");
            Console.WriteLine("======= Login Form =======");

            Console.Write("Username : ");
            string uname = Console.ReadLine();
            Console.Write("Password : ");
            string pass = ReadPassword();

            LoginController.Index(uname, pass);
        }

        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password[0..^1];
                        int position = Console.CursorLeft;
                        Console.SetCursorPosition(position - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(position - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }

        public static void Success()
        {
            ColoredText.Green("Login successful.");
        }

        public static void Failed()
        {
            ColoredText.Red("Email/password is invalid.");
        }
    }
}
