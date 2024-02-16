namespace GangOf4Patterns.Behavioural.Command.Service;

public interface ICommand
{
    void Execute();
    bool CanExecute();

    void Undo();
}