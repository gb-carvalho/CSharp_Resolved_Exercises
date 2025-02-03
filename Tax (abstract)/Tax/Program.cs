using System;
using Tax.Entities;

namespace Tax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int payers_count = 0;
            int.TryParse(Console.ReadLine(), out payers_count);

            for (int i = 0; i < payers_count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company(i/c)? ");
                string type = Console.ReadLine() ?? "";

                Console.Write("Name: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("Anual Income: ");
                double annualIncome;
                double.TryParse(Console.ReadLine(), out annualIncome);

                if (type == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures;
                    double.TryParse(Console.ReadLine(), out healthExpenditures);

                    payers.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else if (type == "c")
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees;
                    int.TryParse(Console.ReadLine(), out numberOfEmployees);

                    payers.Add(new Company(name, annualIncome, numberOfEmployees));
                }
                else
                {
                    Console.WriteLine("Wrong Type");
                    return;
                }
            }

            Console.WriteLine();        
            Console.WriteLine("Taxes Paid: ");
            double sum = 0.0;
            foreach (Payer payer in payers)
            {
                Console.WriteLine(payer);
                sum += payer.TotalTax();
            }
            Console.WriteLine();
            Console.WriteLine($"Total Taxes: ${sum:F2}");
        }

    }
}