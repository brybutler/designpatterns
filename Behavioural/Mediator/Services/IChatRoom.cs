using GangOf4Patterns.Behavioural.Mediator.Models;

namespace GangOf4Patterns.Behavioural.Mediator.Services;

public interface IChatRoom
{
    void Register(TeamMember teamMember);
    void Send(string from, string message);
}