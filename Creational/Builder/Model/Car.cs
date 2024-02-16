using System.Text;
namespace GangOf4Patterns.Creational.Builder.Model;
public class Car
{
    private readonly List<string> _parts = new();
    private readonly string _carType;

    public Car(string carType)
    {
        _carType = carType;
    }

    public void AddPart(string part)
    {
        _parts.Add(part);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var part in _parts)
        {
            sb.Append($"{_carType} has part: {part}");
        }

        return sb.ToString();
    }
}