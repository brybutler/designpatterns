using GangOf4Patterns.Creational;
using GangOf4Patterns.Events.Event.Args;
namespace GangOf4Patterns.Events.Event;
public class RunEvent : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        CarSpeedEvent carSpeed = new(130);
        carSpeed.OnSpeeding += CarSpeedEvent_OnSpeeding;
        carSpeed.OnEconomical += CarSpeedEvent_OnEconomical;

        carSpeed.DoSpeed();

        Console.WriteLine("Max speed reached");

        Console.ReadKey();
    }

    public void CarSpeedEvent_OnSpeeding(object? sender, SpeedInfoEventArgs e)
    {
        if (e.IsSpeeding)
        {
            var tempColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The car is speeding at {e.CurrentSpeed}");
            Console.ForegroundColor = tempColour;
        }
    }


    public void CarSpeedEvent_OnEconomical(object? sender, EconomicInfoEventArgs e)
    {
        if (e.IsEconomical)
        {
            var tempColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The car speed is economical");
            Console.ForegroundColor = tempColour;
        }

    }
}