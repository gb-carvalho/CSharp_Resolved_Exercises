using BankAccount.Entities;
using BankAccount.Entities.Exceptions;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int.TryParse(Console.ReadLine(), out int number);

            Console.Write("Holder: ");
            string holder = Console.ReadLine() ?? "";

            Console.Write("Initial balance: ");
            double.TryParse(Console.ReadLine(), out double initialBalance);

            Console.Write("Withdraw limit: ");
            double.TryParse(Console.ReadLine(), out double withdrawLimit);

            Account account = new Account(number, holder, initialBalance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double.TryParse(Console.ReadLine(), out double withdrawAmount);

            try
            {
                account.Withdraw(withdrawAmount);
                Console.WriteLine($"New balance: {account.Balance:F2}");
            }
            catch (DomainException ex)
            {
                Console.WriteLine($"Withdraw error: {ex.Message}");
            }
        }
    }
}