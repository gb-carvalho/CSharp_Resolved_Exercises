using System.Security.Principal;

namespace Tax.Entities
{
    internal class Company : Payer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int employeeNumber) : base(name, annualIncome)
        {
            NumberOfEmployees = employeeNumber;
        }

        public override double TotalTax()
        {
            double totalTax = 0.0;

            if (NumberOfEmployees > 10)
            {
                totalTax = AnnualIncome * 0.14;
            }
            else if(NumberOfEmployees < 10)
            {
                totalTax = AnnualIncome * 0.16;
            }
            return totalTax;
        }
    }
}
