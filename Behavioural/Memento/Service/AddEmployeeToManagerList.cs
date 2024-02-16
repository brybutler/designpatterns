using GangOf4Patterns.Behavioural.Memento.Models;
using GangOf4Patterns.Behavioural.Memento.Receiver;

namespace GangOf4Patterns.Behavioural.Memento.Service;

public class AddEmployeeToManagerList : ICommand
{
    private readonly IEmployeeManagerRepository _employeeManagerRepository;
    private int _managerId;
    private Employee? _employee;

    public AddEmployeeToManagerList(IEmployeeManagerRepository employeeManagerRepository, int managerId, Employee? employee)
    {
        _employeeManagerRepository = employeeManagerRepository;
        _managerId = managerId;
        _employee = employee;
    }

    public bool CanExecute()
    {
        if (_employee == null)
            return false;

        if (_employeeManagerRepository.HasEmployee(_managerId, _employee.Id))
            return false;

        return true;
    }

    public void Execute()
    {
        if (_employee == null) return;

        _employeeManagerRepository.AddEmployee(_managerId, _employee);
    }

    public void Undo()
    {
        if (_employee == null) return;

        _employeeManagerRepository.RemoveEmployee(_managerId, _employee);
    }

    public AddEmployeeToManagerListMemento CreateMemento()
    {
        return new AddEmployeeToManagerListMemento(_managerId, _employee);
    }

    public void RestoreMemento(AddEmployeeToManagerListMemento memento)
    {
        _managerId = memento.ManagerId;
        _employee = memento.Employee;
    }
}