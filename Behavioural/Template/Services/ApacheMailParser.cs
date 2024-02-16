namespace GangOf4Patterns.Behavioural.Template.Services;
public class ApacheMailParser : MailParser
{
    public override void AuthenticateToServer()
    {
        Console.WriteLine("Connecting to Apache");
    }
}