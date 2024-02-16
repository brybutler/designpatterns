using GangOf4Patterns.Behavioural.State.Context;

namespace GangOf4Patterns.Behavioural.State.Models;
public class RegularState : BankAccountState
{
    public RegularState(decimal balance, BankAccount bankAccount)
    {
        Balance = balance;
        BankAccount = bankAccount;
    }

    public override void Deposit(decimal amount)
    {
        Console.WriteLine($"In {GetType()}, depositing {amount}");
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        Console.WriteLine($"In {GetType()}, withdrawing {amount}");
        Balance -= amount;

        if (Balance < 0)
        {
            BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
        }
    }
}