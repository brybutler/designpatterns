
using GangOf4Patterns.Behavioural.Strategy.Models;

namespace GangOf4Patterns.Behavioural.Strategy.Services;
public class JsonExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Json export: {order.Name}");
    }
}