﻿namespace GangOf4Patterns.Behavioural.Mediator.Models;
public class AccountManager : TeamMember
{
    public AccountManager(string name) : base(name) { }

    public override void Receive(string from, string message)
    {
        Console.WriteLine($"{nameof(AccountManager)} {Name} received:");
        base.Receive(from, message);
    }
}