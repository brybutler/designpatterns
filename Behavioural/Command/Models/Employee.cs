﻿namespace GangOf4Patterns.Behavioural.Command.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}