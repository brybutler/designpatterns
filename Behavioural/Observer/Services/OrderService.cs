using GangOf4Patterns.Behavioural.Observer.Models;

namespace GangOf4Patterns.Behavioural.Observer.Services;
public class OrderService : TicketChangeNotifier
{
    public void CompleteTicketSale(int artistId, int amount)
    {
        Console.WriteLine($"{nameof(OrderService)} is change its state");
        Console.WriteLine($"{nameof(OrderService)} is notifying observers");
        Notify(new TicketChange(artistId, amount));
    }
}