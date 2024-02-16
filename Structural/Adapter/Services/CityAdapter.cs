using GangOf4Patterns.Structural.Adapter.Models;
using GangOf4Patterns.Structural.Adapter.ExternalSystem;

namespace GangOf4Patterns.Structural.Adapter.Services;
public class CityAdapter : ICityAdapter
{
    public ExternalSystem.ExternalSystem ExternalSystem { get; private set; } = new();
    public City GetCity()
    {
        var cityFromExternalSystem = ExternalSystem.GetCity();

        return new City(cityFromExternalSystem.Name, cityFromExternalSystem.Population);
    }
}