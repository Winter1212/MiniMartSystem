using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMartSystem
{
    public class Function
    {



    
        public static void MiniMartApplication()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("1. Mini-Mart");
                Console.WriteLine("2. Add Item");
                Console.WriteLine("3. Exit");
                Console.Write("Please enter your transaction: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MiniMart();
                        break;
                    case "2":
                       AddItem();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (!exit);
        }

        public static void MiniMart()
        {
            Console.WriteLine("Mini-Mart Application");

            for (int i = 0; i < MiniMartSystem.items.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {MiniMartSystem.items[i]}: {MiniMartSystem.prices[i]}R");
            }

            Console.Write("Which item do you want to buy?: ");
            int choice = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine($"{MiniMartSystem.items[choice]}: {MiniMartSystem.prices[choice]}R");
            Console.Write("QTY: ");
            int qty = int.Parse(Console.ReadLine());
            int total = CalculateTotal(MiniMartSystem.prices[choice], qty);
            Console.WriteLine($"Total: {total}R");

            Console.Write("Get money: ");
            double money = double.Parse(Console.ReadLine());

            double paybackRiel = CalculatePaybackRiel(money, total);
            double paybackDollar = CalculatePaybackDollar(paybackRiel);

            Console.WriteLine($"Payback:");
            Console.WriteLine($"1. Riel: {paybackRiel}R");
            Console.WriteLine($"2. Dollar: {paybackDollar}$");

            Console.Write("Do you want to continue? (Yes/No): ");
            string cont = Console.ReadLine();

            if (cont.ToLower() == "yes")
                MiniMartApplication();
            else
                Console.WriteLine("Welcome to Mini-mart System");
        }
        public static int CalculateTotal(int price, int qty)
        {
            return price * qty;
        }

        public static double CalculatePaybackRiel(double money, int total)
        {
            return money - total;
        }

        public static double CalculatePaybackDollar(double paybackRiel)
        {
            return paybackRiel / MiniMartSystem.exchangeRate;
        }



        public static void AddItem()
        {
            Console.WriteLine("Add Item");
            Console.Write("Enter number of Item for add: ");
            int numItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numItems; i++)
            {
                Console.Write("Enter Item-Name: ");
                string itemName = Console.ReadLine();
                Console.Write("Enter Price: ");
                int itemPrice = int.Parse(Console.ReadLine());
                Console.Write("Enter QTY: ");
                int itemQty = int.Parse(Console.ReadLine());

                Array.Resize(ref MiniMartSystem.items, MiniMartSystem.items.Length + 1);
                Array.Resize(ref MiniMartSystem.prices, MiniMartSystem.prices.Length + 1);
                Array.Resize(ref MiniMartSystem.quantities, MiniMartSystem.quantities.Length + 1);

                MiniMartSystem.items[MiniMartSystem.items.Length - 1] = itemName;
                MiniMartSystem.prices[MiniMartSystem.prices.Length - 1] = itemPrice;
                MiniMartSystem.quantities[MiniMartSystem.quantities.Length - 1] = itemQty;
            }

            Console.Write("Do you want to add more? (Yes/No): ");
            string cont = Console.ReadLine();

            if (cont.ToLower() == "yes")
                AddItem();
            else
                MiniMartApplication();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

}

