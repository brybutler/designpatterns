using GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Types;

namespace GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Services;
public class FixedPricePaymentService : PaymentService
{
    public override void AddBillingInvoice(BillingInvoiceRequest billingInvoiceRequest)
    {
        billingInvoiceRequest.Description = "Fixed price payment";
        base.AddBillingInvoice(billingInvoiceRequest);

    }

    public override void AddHistoryPaymentsInvoice(BillingInvoiceRequest billingInvoiceRequest)
    {
        billingInvoiceRequest.Description = "fixed price";
        base.AddHistoryPaymentsInvoice(billingInvoiceRequest);
    }

    public override void AddCredits(int _)
    {
        base.AddCredits(0);
    }
}

