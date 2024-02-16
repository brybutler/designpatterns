using GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Types;

namespace GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Services;
public class PaymentFactory
{
    private IPaymentService _paymentService;

    public PaymentFactory(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void AddBillingInvoice()
    {

        _paymentService.AddBillingInvoice(new BillingInvoiceRequest
        {
            StripeCustomerId = 1,
            Credits = 1
        });
        Console.WriteLine("Add Billing Invoice");
    }

    public void AddHistoryPaymentsInvoice()
    {
        _paymentService.AddHistoryPaymentsInvoice(new BillingInvoiceRequest
        {
            Credits = 1,
            StripeCustomerId = 1
        });

        Console.WriteLine("Add History Payments Invoice");
    }
}

