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
            Console.WriteLine(
                "Welcome to the Pet Care!\n" +
                "Please log in to your account.\n" +
                "======= Login Form ======="
            );

            string uname = InputUname();
            string pass = InputPass();

            LoginController.Index(uname, pass);
        }

        private static string InputUname()
        {
            Console.Write("Username : ");
            return Console.ReadLine();
        }

        private static string InputPass()
        {
            Console.Write("Password : ");
            return ReadPassword();
        }

        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            password = EvaluateTyping(info, password);

            Console.WriteLine();
            return password;
        }

        private static string EvaluateTyping(ConsoleKeyInfo info, string password)
        {
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
