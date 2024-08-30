namespace TaxCalculationSystem.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double YearIncome { get; set; }
        public TaxPayer(string name, double yearIncome)
        {
            Name = name;
            YearIncome = yearIncome;
        }
        public abstract double TaxExpense();
    }
}
