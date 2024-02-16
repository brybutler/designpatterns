namespace GangOf4Patterns.Structural.Adapter.ExternalSystem;
public class CityFromExternalSystem
{
    public string Name { get; private set; }
    public string Nickname { get; private set; }
    public int Population { get; private set; }

    public CityFromExternalSystem(string name, string nickname, int population)
    {
        Name = name;
        Nickname = nickname;
        Population = population;
    }
}