namespace GangOf4Patterns.Structural.Decorator.Services;
public class OnPremiseMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"OnPremise Send Message {message}");
        return true;
    }
}