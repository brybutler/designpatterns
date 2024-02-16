using GangOf4Patterns.Behavioural.Mediator.Models;
using GangOf4Patterns.Behavioural.Mediator.Services;
using GangOf4Patterns.Creational;
namespace GangOf4Patterns.Behavioural.Mediator;
public class RunMediator : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;
        TeamChatRoom teamChatRoom = new();

        var sven = new Lawyer("Sven");
        var andrew = new Lawyer("Andrew");

        var ann = new AccountManager("Ann");
        var ian = new AccountManager("Ian");
        var tim = new AccountManager("Tim");

        teamChatRoom.Register(sven);
        teamChatRoom.Register(andrew);
        teamChatRoom.Register(ann);
        teamChatRoom.Register(ian);
        teamChatRoom.Register(tim);

        ann.Send("Hi how is it going");
        sven.Send("Hello");


        Console.ReadKey();
    }
}