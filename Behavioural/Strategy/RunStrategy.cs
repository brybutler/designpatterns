using GangOf4Patterns.Behavioural.Strategy.Models;
using GangOf4Patterns.Behavioural.Strategy.Services;
using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Behavioural.Strategy;
public class RunStrategy : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        var order = new Order("John Toys", 5, "Pokemon");
        order.ExportService = new CsvExportService();
        order.Export();

        order.ExportService = new JsonExportService();
        order.Export();

        order.ExportService = new XmlExportService();
        order.Export();

        Console.ReadKey();
    }
}
