using System;
using System.Globalization;
using ContractProgram.Entities;
using ContractProgram.Services;

namespace ContractProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine() ?? "", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double.TryParse(Console.ReadLine(), out double value);
            Console.Write("Enter number of installments: ");
            int.TryParse(Console.ReadLine(), out int installments);

            Contract contract = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.CalculateInstallment(contract, installments);

            Console.WriteLine();
            Console.WriteLine("Installments: ");

            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}