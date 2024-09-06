using BankAccountManager.Entities;
using BankAccountManager.Entities.Exceptions;


try
{
    Console.WriteLine("Enter account data:");
    Console.Write("Number: ");
    int accountNum = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string accountHolder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double inititalBalance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    Account acc1 = new Account(accountNum, accountHolder, inititalBalance, withdrawLimit);

    Console.Write("Enter the amount for withdraw: ");
    double withdrawAmount = double.Parse(Console.ReadLine());

    acc1.Withdraw(withdrawAmount);
}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}