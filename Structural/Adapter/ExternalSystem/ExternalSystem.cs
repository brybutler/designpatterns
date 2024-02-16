namespace GangOf4Patterns.Structural.Adapter.ExternalSystem;
public class ExternalSystem
{
    public CityFromExternalSystem GetCity()
    {
        return new CityFromExternalSystem("Dublin", "Dirty old town", 1500000);
    }
}