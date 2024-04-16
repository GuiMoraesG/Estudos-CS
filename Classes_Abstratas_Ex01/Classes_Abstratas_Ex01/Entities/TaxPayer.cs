namespace Classes_Abstratas_Ex01.Entities
{
    abstract internal class TaxPayer
    {
        public string Name {  get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TotalTax();
    }
}
