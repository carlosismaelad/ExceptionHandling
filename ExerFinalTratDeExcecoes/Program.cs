using System.Globalization;
using ExerFinalTratDeExcecoes.Entities;
using ExerFinalTratDeExcecoes.Entities.Exceptions;

namespace ExerFinalTratDeExcecoes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Enter acount data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, initialBalance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}