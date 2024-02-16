using GangOf4Patterns.Behavioural.Strategy.Models;

namespace GangOf4Patterns.Behavioural.Strategy.Services;
public class XmlExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"XML export: {order.Name}");
    }
}