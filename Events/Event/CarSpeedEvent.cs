using GangOf4Patterns.Events.Event.Args;

namespace GangOf4Patterns.Events.Event;
public class CarSpeedEvent
{
    public event EventHandler<SpeedInfoEventArgs> OnSpeeding;
    public event EventHandler<EconomicInfoEventArgs> OnEconomical;

    private int _currentSpeed = 0;

    private int _maxSpeed = 0;

    public CarSpeedEvent(int maxSpeed = 100)
    {
        _maxSpeed = maxSpeed;
    }
    public void DoSpeed()
    {
        for (var i = 0; i <= 200; i = i + 10)
        {
            _currentSpeed = i;
            Console.WriteLine($"Current speed {i}");

            if (OnSpeeding != null)
                OnSpeeding.Invoke(this, new SpeedInfoEventArgs()
                {
                    CurrentSpeed = _currentSpeed,
                    IsSpeeding = _currentSpeed > _maxSpeed
                });

            if (OnEconomical != null)
                OnEconomical.Invoke(this, new EconomicInfoEventArgs
                {
                    IsEconomical = _currentSpeed < 60
                });
        }
    }
}