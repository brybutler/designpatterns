﻿namespace GangOf4Patterns.Behavioural.Command.Models;
public class Manager : Employee
{
    public List<Employee> Employees = new();

    public Manager(int id, string name) : base(id, name)
    {

    }
}