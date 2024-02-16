using GangOf4Patterns.Structural.Adapter.Models;

namespace GangOf4Patterns.Structural.Adapter.Services;
public class CityClassAdapter : ExternalSystem.ExternalSystem, ICityAdapter
{
    public City GetCity()
    {
        var cityFromExternalSystem = base.GetCity();

        return new City(cityFromExternalSystem.Name, cityFromExternalSystem.Population);
    }
}