using GangOf4Patterns.Behavioural.Mediator.Models;

namespace GangOf4Patterns.Behavioural.Mediator.Services;
public class TeamChatRoom : IChatRoom
{
    private readonly Dictionary<string, TeamMember> teamMembers = new();

    public void Register(TeamMember teamMember)
    {
        teamMember.SetChatroom(this);
        if (!teamMembers.ContainsKey(teamMember.Name))
        {
            teamMembers.Add(teamMember.Name, teamMember);
        }
    }

    public void Send(string from, string message)
    {
        foreach (var teamMember in teamMembers.Values)
        {
            teamMember.Receive(from, message);
        }
    }
}