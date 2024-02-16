using GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Types;

namespace GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Services;
public abstract class PaymentService : IPaymentService
{
    public virtual void AddBillingInvoice(BillingInvoiceRequest billingInvoiceRequest)
    {
        var invoice = new OcrexXeroInvoiceBatchImport()
        {
            LineItems = billingInvoiceRequest.Description

        };

        Console.WriteLine($"LineItems {invoice.LineItems}");
    }

    public virtual void AddHistoryPaymentsInvoice(BillingInvoiceRequest billingInvoiceRequest)
    {
        Console.WriteLine($"Sub payment service abi {billingInvoiceRequest.Credits}");

        var historyPayment = new HistoryPayment()
        {
            Credits = billingInvoiceRequest.Credits,
            Description = billingInvoiceRequest.Description

        };

        Console.WriteLine($"Description {historyPayment.Description}");
    }

    public virtual void AddCredits(int credits)
    {
        Console.WriteLine($"Add Credits {credits}");
    }

}

