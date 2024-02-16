using GangOf4Patterns.Behavioural.Observer.Models;

namespace GangOf4Patterns.Behavioural.Observer.Services;
public class TicketStockService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        Console.WriteLine($"{nameof(TicketStockService)} notified of ticket change: artist {ticketChange.ArtistId}, amount {ticketChange.Amount}");
    }
}