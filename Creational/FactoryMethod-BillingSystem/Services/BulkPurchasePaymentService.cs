using GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Types;

namespace GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Services;

public class BulkPurchasePaymentService : PaymentService
{
    public override void AddBillingInvoice(BillingInvoiceRequest billingInvoiceRequest)
    {
        Console.WriteLine($"Bulk payment {billingInvoiceRequest.Credits}");
        billingInvoiceRequest.Description = "Bulk purchase payment line item";
        base.AddBillingInvoice(billingInvoiceRequest);

    }

    public override void AddHistoryPaymentsInvoice(BillingInvoiceRequest billingInvoiceRequest)
    {
        billingInvoiceRequest.Description = "Bulk purchase payment description";
        base.AddHistoryPaymentsInvoice(billingInvoiceRequest);
    }

    public override void AddCredits(int credits)
    {
        Console.WriteLine($"Sub add credits service {credits}");
        base.AddCredits(credits);
    }
}

