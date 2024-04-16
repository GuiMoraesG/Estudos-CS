namespace Classes_Abstratas_Ex01.Entities
{
    internal class IndividualTaxPayer : TaxPayer
    {
        public double Health { get; set; }

        public IndividualTaxPayer(string name, double annualIncome, double health) : base (name, annualIncome)
        {
            Health = health;
        }

        public override double TotalTax()
        {
            if (AnnualIncome < 15000)
            {
                return (AnnualIncome * 0.15) - (Health * 0.50);
            }

            return (AnnualIncome * 0.25) - (Health * 0.50);
        }
    }
}
