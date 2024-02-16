namespace GangOf4Patterns.Structural.Decorator.Services;
public class CloudMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Cloud Send Message {message}");
        return true;
    }
}