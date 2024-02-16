﻿namespace GangOf4Patterns.Behavioural.Memento.Models;
public class AddEmployeeToManagerListMemento
{
    public int ManagerId { get; private set; }

    public Employee? Employee { get; private set; }

    public AddEmployeeToManagerListMemento(int managerId, Employee? employee)
    {
        ManagerId = managerId;
        Employee = employee;
    }
}