using GangOf4Patterns.Behavioural.Strategy.Models;
namespace GangOf4Patterns.Behavioural.Strategy.Services;
public class CsvExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"CSV export: {order.Name}");
    }
}