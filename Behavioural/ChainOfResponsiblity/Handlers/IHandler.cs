namespace GangOf4Patterns.Behavioural.ChainOfResponsiblity.Handlers;
public interface IHandler<T> where T : class
{
    IHandler<T> SetSuccessor(IHandler<T> successor);
    void Handle(T request);
}