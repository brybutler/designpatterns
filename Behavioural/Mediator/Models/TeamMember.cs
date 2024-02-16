using GangOf4Patterns.Behavioural.Mediator.Services;

namespace GangOf4Patterns.Behavioural.Mediator.Models;
public abstract class TeamMember
{
    private IChatRoom? _chatRoom;
    public string Name { get; set; }
    public TeamMember(string name)
    {
        Name = name;
    }

    internal void SetChatroom(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public void Send(string message)
    {
        _chatRoom?.Send(Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"Message {from} to {Name}: {message}");
    }
}