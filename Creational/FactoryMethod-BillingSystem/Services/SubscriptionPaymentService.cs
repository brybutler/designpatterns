using GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Types;
namespace GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Services;

public class SubscriptionPaymentService : PaymentService
{
    public override void AddBillingInvoice(BillingInvoiceRequest billingInvoiceRequest)
    {
        billingInvoiceRequest.Description = "Subscription line item";
        base.AddBillingInvoice(billingInvoiceRequest);

    }

    public override void AddHistoryPaymentsInvoice(BillingInvoiceRequest billingInvoiceRequest)
    {
        billingInvoiceRequest.Description = "Subscription payment";
        base.AddHistoryPaymentsInvoice(billingInvoiceRequest);
    }

    public override void AddCredits(int credits)
    {
        base.AddCredits(credits);
    }
}

