using GangOf4Patterns.Behavioural.Observer.Services;
using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Behavioural.Observer;
public class RunObserver : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        TicketStockService ticketStockService = new();
        TicketResellerService ticketResellerService = new();
        OrderService orderService = new();

        orderService.AddObserver(ticketStockService);
        orderService.AddObserver(ticketResellerService);

        orderService.CompleteTicketSale(1, 2);

        orderService.RemoveObserver(ticketResellerService);

        orderService.CompleteTicketSale(2, 4);

        Console.ReadKey();
    }
}