using GangOf4Patterns.Behavioural.State.Models;

namespace GangOf4Patterns.Behavioural.State.Context;
public class BankAccount
{
    public BankAccountState BankAccountState { get; set; }
    public decimal Balance
    {
        get { return BankAccountState.Balance; }
    }

    public BankAccount()
    {
        BankAccountState = new RegularState(200, this);
    }

    public void Deposit(decimal amount)
    {
        BankAccountState.Deposit(amount);
    }

    public void Withdraw(decimal amount)
    {
        BankAccountState.Withdraw(amount);
    }
}