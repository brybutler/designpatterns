using GangOf4Patterns.Behavioural.Memento.Models;
namespace GangOf4Patterns.Behavioural.Memento.Receiver;
public class EmployeeManagerRepository : IEmployeeManagerRepository
{
    private List<Manager> _managers = new()
    {
        new Manager(1, "Katie"),
        new Manager(2, "Geoff")
    };

    public void AddEmployee(int managerId, Employee employee)
    {
        _managers.First(_ => _.Id == managerId).Employees.Add(employee);
    }

    public void RemoveEmployee(int managerId, Employee employee)
    {
        _managers.First(_ => _.Id == managerId).Employees.Remove(employee);
    }

    public bool HasEmployee(int managerId, int employeeId)
    {
        return _managers.First(_ => _.Id == managerId).Employees.Any(_ => _.Id == employeeId);
    }

    public void WriteDataStore()
    {
        foreach (var manager in _managers)
        {
            Console.WriteLine($"Manager {manager.Id}, {manager.Name}");
            if (manager.Employees.Any())
            {
                foreach (var employee in manager.Employees)
                {
                    Console.WriteLine($"Employee {employee.Id}, {employee.Name}");
                }
            }
            else
            {
                Console.WriteLine("No employees");
            }
        }
    }
}