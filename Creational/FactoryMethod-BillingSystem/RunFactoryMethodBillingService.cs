
using GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Services;
using GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Types;

namespace GangOf4Patterns.Creational.FactoryMethod_BillingSystem;
public class RunFactoryMethodBillingService : ICreational
{
    public void Execute(string title)
    {
        Console.Title = "Builder - Billing System";
        var subscriptionPayment = new PaymentProcess(new SubscriptionPaymentService());
        subscriptionPayment.Process(new BillingInvoiceRequest()
        {
            Credits = 10,
            Description = "Subscription",
            StripeCustomerId = 1
        });

        var bulkPayment = new PaymentProcess(new BulkPurchasePaymentService());
        bulkPayment.Process(new BillingInvoiceRequest()
        {
            Credits = 20,
            Description = "Bulk",
            StripeCustomerId = 1
        });

        var fixedPrice = new PaymentProcess(new FixedPricePaymentService());
        fixedPrice.Process(new BillingInvoiceRequest()
        {
            Credits = 0,
            Description = "Fixed price",
            StripeCustomerId = 1
        });

        Console.ReadKey();
    }
}

