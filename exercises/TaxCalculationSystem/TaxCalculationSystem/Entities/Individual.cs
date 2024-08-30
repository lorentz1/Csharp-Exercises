using TaxCalculationSystem.Entities;

namespace TaxCalculationSystem.Entitie
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenses { get; set; }
        public Individual(string name, double yearIncome, double healthexpenses) : base(name, yearIncome)
        {
            HealthExpenses = healthexpenses;
        }
        public override double TaxExpense()
        {
            if (YearIncome < 20000.0)
            {
                return YearIncome * 0.15 - HealthExpenses * 0.5;
            }
            else
            {
                return YearIncome * 0.25 - HealthExpenses * 0.5;
            }
        }

    }
}
