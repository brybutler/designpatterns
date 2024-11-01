﻿using GangOf4Patterns.Behavioural.Memento.Models;

namespace GangOf4Patterns.Behavioural.Memento.Service;
public class CommandManager
{
    private readonly Stack<AddEmployeeToManagerListMemento> _mementos = new();
    private AddEmployeeToManagerList? _command;

    public void Invoke(ICommand command)
    {
        if (command == null)
        {
            _command = (AddEmployeeToManagerList)command;
        }

        if (command.CanExecute())
        {
            command.Execute();
            _mementos.Push(((AddEmployeeToManagerList)command).CreateMemento());
        }
    }

    public void Undo()
    {
        if (_mementos.Any())
        {
            _command?.RestoreMemento(_mementos.Pop());
            _command?.Undo();
        }
    }

    public void UndoAll()
    {
        while (_mementos.Any())
        {
            _command?.RestoreMemento(_mementos.Pop());
            _command?.Undo();
        }
    }
}