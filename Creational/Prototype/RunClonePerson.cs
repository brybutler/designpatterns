

namespace GangOf4Patterns.Creational.Prototype;

public class RunClonePerson: ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        var manager = new Manager("Jim");
        var managerClone = (Manager)manager.Clone();
        Console.WriteLine($"Manager was cloned: {managerClone.Name}");


        var employee = new Employee("Kevin", manager);
        var employeeClone = (Employee)employee.Clone();
        Console.WriteLine($"Employee was cloned: {employeeClone.Name} with manager {employeeClone.Manager.Name}");

        //change the name
        manager.Name = "Karen";
        Console.WriteLine($"Manager name of employee has changed to {employeeClone.Manager.Name}");

        //use deep copy
        var employeeClone2 = (Employee)employee.Clone(true);
        manager.Name = "Thomas";
        Console.WriteLine($"Manager name of employee hasn't changed from {employeeClone2.Manager.Name}");

        Console.ReadKey();
    }
}

