using GangOf4Patterns.Behavioural.Command.Models;
using GangOf4Patterns.Behavioural.Command.Receiver;
using GangOf4Patterns.Behavioural.Command.Service;
using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Behavioural.Command;

public class RunCommand : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;
        CommandManager commandManager = new();
        IEmployeeManagerRepository repository = new EmployeeManagerRepository();

        commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(111, "Kevin")));
        repository.WriteDataStore();

        commandManager.Undo();
        repository.WriteDataStore();

        commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(222, "Joe")));
        repository.WriteDataStore();

        commandManager.Invoke(new AddEmployeeToManagerList(repository, 2, new Employee(333, "Jim")));
        repository.WriteDataStore();

        Console.ReadKey();
    }
}

