using GangOf4Patterns.Behavioural.Command.Models;

namespace GangOf4Patterns.Behavioural.Command.Receiver;
public interface IEmployeeManagerRepository
{
    void AddEmployee(int managerId, Employee employee);
    void RemoveEmployee(int managerId, Employee employee);
    bool HasEmployee(int managerId, int employeeId);
    void WriteDataStore();
}