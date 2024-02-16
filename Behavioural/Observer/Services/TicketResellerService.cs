using GangOf4Patterns.Behavioural.Observer.Models;

namespace GangOf4Patterns.Behavioural.Observer.Services;
public class TicketResellerService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        Console.WriteLine($"{nameof(TicketResellerService)} notified of ticket change: artist {ticketChange.ArtistId}, amount {ticketChange.Amount}");
    }
}