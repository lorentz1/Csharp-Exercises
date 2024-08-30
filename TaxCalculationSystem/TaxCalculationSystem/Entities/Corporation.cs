namespace TaxCalculationSystem.Entities
{
    internal class Corporation : TaxPayer
    {
        public int Employees { get; set; }

        public Corporation(string name, double yearIncome, int employees) : base(name, yearIncome)
        {
            Employees = employees;
        }
        public override double TaxExpense()
        {
            if (Employees <= 10) 
            {
                return YearIncome * 0.16;
            }
            else
            {
                return YearIncome * 0.14;
            }
        }
    }
}
