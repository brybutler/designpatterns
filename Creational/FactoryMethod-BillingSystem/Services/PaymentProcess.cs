
using GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Types;

namespace GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Services;
public class PaymentProcess
{
    private readonly PaymentService _builder;

    public PaymentProcess(PaymentService builder)
    {
        _builder = builder;

    }
    
    public void Process(BillingInvoiceRequest billingInvoiceRequest)
    {
        _builder.AddBillingInvoice(billingInvoiceRequest);
        _builder.AddHistoryPaymentsInvoice(billingInvoiceRequest);
        _builder.AddCredits(billingInvoiceRequest.Credits);
    }
}

