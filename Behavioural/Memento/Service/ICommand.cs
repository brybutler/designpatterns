namespace GangOf4Patterns.Behavioural.Memento.Service;
public interface ICommand
{
    void Execute();
    bool CanExecute();
}