using GangOf4Patterns.Behavioural.Memento.Models;
namespace GangOf4Patterns.Behavioural.Memento.Receiver;
public interface IEmployeeManagerRepository
{
    void AddEmployee(int managerId, Employee employee);
    void RemoveEmployee(int managerId, Employee employee);
    bool HasEmployee(int managerId, int employeeId);
    void WriteDataStore();
}