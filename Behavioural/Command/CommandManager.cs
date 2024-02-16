using GangOf4Patterns.Behavioural.Command.Service;

namespace GangOf4Patterns.Behavioural.Command;

public class CommandManager
{
    private readonly Stack<ICommand> _commands = new();
    public void Invoke(ICommand command)
    {
        if (command.CanExecute())
        {
            command.Execute();
            _commands.Push(command);
        }
    }

    public void Undo()
    {
        if(_commands.Any())
            _commands.Pop()?.Undo();
    }

    public void UndoAll()
    {
        while (_commands.Any())
            _commands.Pop()?.Undo();
    }
}