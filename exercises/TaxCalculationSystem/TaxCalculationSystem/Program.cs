using System.Globalization;
using TaxCalculationSystem.Entitie;
using TaxCalculationSystem.Entities;

List<TaxPayer> taxPayers = new List<TaxPayer>();

Console.Write("Enter the number of taxpayers: ");
int numberOfTaxPayers = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfTaxPayers; i++)
{
    Console.WriteLine($"#{i} Tax Payer Data");
    Console.Write("(i) Individual (c) Corporation> ");
    char op = char.Parse(Console.ReadLine());
    Console.Write("Enter the name: ");
    string name = Console.ReadLine();
    Console.Write("Enter the year income: ");
    double yearIncome = double.Parse(Console.ReadLine());
    if (op == 'i')
    {
        Console.Write("Enter the health expenses: ");
        double healthExpenses = double.Parse(Console.ReadLine());
        taxPayers.Add(new Individual(name, yearIncome, healthExpenses));
    }
    else
    {
        Console.Write("Enter the number of employees: ");
        int employeeNumber = int.Parse(Console.ReadLine());
        taxPayers.Add(new Corporation(name, yearIncome, employeeNumber));
    }
}

Console.WriteLine();
double totalTax = 0.0;
Console.WriteLine("TAXES PAID: ");
foreach (TaxPayer payer in taxPayers)
{
    double tempTax = payer.TaxExpense();
    Console.WriteLine($"{payer.Name}: $ {tempTax.ToString("F2", CultureInfo.InvariantCulture)}");
    totalTax += tempTax;
}
Console.WriteLine();
Console.WriteLine($"TOTAL TAXES: $ {totalTax.ToString("F2", CultureInfo.InvariantCulture)}");