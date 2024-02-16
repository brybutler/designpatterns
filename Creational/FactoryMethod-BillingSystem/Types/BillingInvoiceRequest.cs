namespace GangOf4Patterns.Creational.FactoryMethod_BillingSystem.Types;
public class BillingInvoiceRequest
{
    public int Credits { get; set; }
    public int StripeCustomerId { get; set; }

    public string Description { get; set; }
}

