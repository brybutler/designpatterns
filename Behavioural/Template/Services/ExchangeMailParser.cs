namespace GangOf4Patterns.Behavioural.Template.Services;
public class ExchangeMailParser : MailParser
{
    public override void FindServer()
    {
        Console.WriteLine("Finding Exchange server...");
    }

    public override void AuthenticateToServer()
    {
        Console.WriteLine("Connecting to Exchange");
    }
}
