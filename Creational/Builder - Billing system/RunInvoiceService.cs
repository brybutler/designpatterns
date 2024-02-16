namespace GangOf4Patterns.Creational;

public class RunInvoiceService : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;
        var creditsService = new CreditsService();
        var paymentService = new PaymentService();
        var subscriptionCredits = new PaymentWithCredits(creditsService, paymentService);
        subscriptionCredits.AddInvoice();
        
        Console.ReadKey();
    }
}

