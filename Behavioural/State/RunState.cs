using GangOf4Patterns.Behavioural.State.Context;
using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Behavioural.State;
public class RunState : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        BankAccount bankAccount = new();
        Console.WriteLine($"Opening balance {bankAccount.Balance}");
        bankAccount.Deposit(100);
        bankAccount.Withdraw(500);
        bankAccount.Withdraw(100);

        Console.WriteLine($"Balance {bankAccount.Balance}");

        Console.ReadKey();
    }
}
