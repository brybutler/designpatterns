using GangOf4Patterns.Structural.Adapter.Services;

namespace GangOf4Patterns.Creational;
public class RunConvertCity: ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        var adapter = new CityAdapter();
        var city = adapter.GetCity();
        Console.WriteLine($"{city.FullName} - {city.Inhabitants}");


        // just a tidier implementation
        var classAdapter = new CityClassAdapter();
        var classCity = classAdapter.GetCity();
        Console.WriteLine($"{classCity.FullName} - {classCity.Inhabitants}");

        Console.ReadKey();
    }
}

