namespace GangOf4Patterns.Events.Delegate;
public class CarSpeed
{
    public delegate void NotifySpeeding();
    public event NotifySpeeding? OnSpeeding;
    public event NotifySpeeding? OnEconomical;

    private int _currentSpeed = 0;

    private int _maxSpeed = 0;

    public CarSpeed(int maxSpeed = 100)
    {
        _maxSpeed = maxSpeed;
    }
    public void DoSpeed()
    {
        for (var i = 0; i <= 200; i = i + 10)
        {
            _currentSpeed = i;
            Console.WriteLine($"Current speed {i}");

            if (_currentSpeed > _maxSpeed && OnSpeeding != null)
                OnSpeeding.Invoke();

            if (_currentSpeed < 60 && OnEconomical != null)
                OnEconomical.Invoke();


        }
    }

    
}

