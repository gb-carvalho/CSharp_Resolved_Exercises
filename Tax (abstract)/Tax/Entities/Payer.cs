namespace Tax.Entities
{
    internal abstract class Payer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Payer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TotalTax();

        public override string ToString()
        {
            return $"{Name}: ${TotalTax():F2}";
        }
    }
}
