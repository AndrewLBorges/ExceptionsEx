using Exceptions.Entities;
using Exceptions.Entities.Exceptions;
using System;
using System.Globalization;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(n, holder, initial, limit);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                acc.Withdraw(amount);
                Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: " + e.Message);
            }
        }
    }
}
