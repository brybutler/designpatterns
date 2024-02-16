namespace GangOf4Patterns.Structural.Facade.Services;
public class DayOfTheWeekFactorService
{
    public double CalculateDayOfTheWeekFactor()
    {
        switch (DateTime.Today.DayOfWeek)
        {
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                return 0.8;
            default:
                return 1.2;
        }
    }
}