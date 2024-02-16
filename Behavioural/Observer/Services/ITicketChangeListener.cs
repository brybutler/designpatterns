using GangOf4Patterns.Behavioural.Observer.Models;

namespace GangOf4Patterns.Behavioural.Observer.Services;
public interface ITicketChangeListener
{
    void ReceiveTicketChangeNotification(TicketChange ticketChange);
}