using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Events.Delegate;

public class RunDelegate : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        CarSpeed carSpeed = new(130);
        carSpeed.OnSpeeding += CarSpeed_OnSpeeding;
        carSpeed.OnSpeeding += CarSpeed_OnSpeedingWarning;
        carSpeed.OnEconomical += CarSpeed_OnEconomical;

        carSpeed.DoSpeed();

        Console.WriteLine("Max speed reached");

        Console.ReadKey();
    }

    public void CarSpeed_OnSpeeding()
    {
        var tempColour = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The car is speeding");
        Console.ForegroundColor = tempColour;
    }

    public void CarSpeed_OnSpeedingWarning()
    {
        var tempColour = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Slow down");
        Console.ForegroundColor = tempColour;
    }

    public void CarSpeed_OnEconomical()
    {
        var tempColour = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The car speed is economical");
        Console.ForegroundColor = tempColour;
    }
}