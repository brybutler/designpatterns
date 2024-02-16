using GangOf4Patterns.Structural.Decorator.Services;

namespace GangOf4Patterns.Structural.Decorator.Decorators;
public abstract class MailServiceDecoratorBase : IMailService
{
    private readonly IMailService _mailService;
    public MailServiceDecoratorBase(IMailService mailService)
    {
        _mailService = mailService;
    }

    public virtual bool SendMail(string message)
    {
        return _mailService.SendMail(message);
    }
}