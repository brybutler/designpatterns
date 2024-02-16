using GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Types;

namespace GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Services;
public interface IPaymentService
{
    public void AddBillingInvoice(BillingInvoiceRequest billingInvoiceRequest);

    public void AddHistoryPaymentsInvoice(BillingInvoiceRequest billingInvoiceRequest);

    public void AddCredits(int credits);
}

