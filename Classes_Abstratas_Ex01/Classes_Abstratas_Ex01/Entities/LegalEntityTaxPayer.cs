using System;

namespace Classes_Abstratas_Ex01.Entities
{
    internal class LegalEntityTaxPayer : TaxPayer
    {
        public int Employees { get; set; }

        public LegalEntityTaxPayer(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double TotalTax()
        {
           return (Employees < 10) ? AnnualIncome * 0.16 : AnnualIncome * 0.14;
        }
    }
}
