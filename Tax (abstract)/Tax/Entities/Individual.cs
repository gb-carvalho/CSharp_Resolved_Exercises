namespace Tax.Entities
{
    internal class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures): base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TotalTax()
        {
            double totalTax = 0.0;

            if (AnnualIncome < 20000.00)
            {
                totalTax = Math.Max((AnnualIncome * 0.15) - (HealthExpenditures * 0.50), 0.0);
            }
            else if (AnnualIncome >= 20000.00)
            {
                totalTax = Math.Max((AnnualIncome * 0.25) - (HealthExpenditures * 0.50), 0.0);
            }

            return totalTax;
        }
    }
}
