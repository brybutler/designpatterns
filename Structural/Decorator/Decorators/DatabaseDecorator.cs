using GangOf4Patterns.Structural.Decorator.Services;

namespace GangOf4Patterns.Structural.Decorator.Decorators;
public class DatabaseDecorator : MailServiceDecoratorBase
{
    public List<string> SentMessages { get; private set; } = new List<string>();

    public DatabaseDecorator(IMailService mailService) : base(mailService) { }

    public override bool SendMail(string message)
    {
        if (base.SendMail(message))
        {
            SentMessages.Add(message);
            return true;
        }

        return false;
    }
}