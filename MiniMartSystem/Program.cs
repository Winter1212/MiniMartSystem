using System;

namespace MiniMartSystem
{
    class MiniMartSystem
    {
        public static string username = "";
        public static string password = "";
        public static string[] items = { "Coca", "Fanta", "ABC", "Cambodia", "Ice-cream", "Viso" };
        public static int[] prices = { 2000, 2000, 2000, 5000, 3000, 4000 };
        public static int[] quantities = { 10, 10, 10, 10, 10, 10 };
        public static double exchangeRate = 4000;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mini-mart System");

            bool loggedIn = false;
            do
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                username = username.ToLower();
                password = password.ToLower();

                if (username.Equals("admin") && password.Equals("admin"))
                {
                    loggedIn = true;
                    Console.WriteLine("Welcome, admin!");
                    Function.MiniMartApplication();
                }
                else
                {
                    Console.WriteLine("Invalid username/password");
                }
            } while (!loggedIn);
        }
    }
}
