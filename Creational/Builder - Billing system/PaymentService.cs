using System.Text;

namespace GangOf4Patterns.Creational
{



    public interface ICreditsService
    {
        void AddCredits(int userId, int creditsToAdd);
        int GetCreditBalance(int userId);
    }

    public class CreditsService : ICreditsService
    {
        public void AddCredits(int userId, int creditsToAdd)
        {
            var creditBalance = GetCreditBalance(userId);
            Console.WriteLine($"Add {creditsToAdd} credits for {userId}. Total: {creditBalance + creditsToAdd}");
        }

        public int GetCreditBalance(int userId)
        {
            Console.WriteLine($"Balance for {userId} is 10");
            return 10;
        }
    }

    public interface IPaymentService
    {
        void AddBillingInvoice();

        void AddHistoryPayment();
    }


    public class PaymentService : IPaymentService
    {

        public virtual void AddBillingInvoice()
        {
            Console.WriteLine("Add billing invoice");
        }

        public virtual void AddHistoryPayment()
        {
            Console.WriteLine("Add history payment");
        }
    }

    public interface IProcessWebHookService
    {
        void AddInvoice();
    }

    public abstract class ProcessWebHookService : IProcessWebHookService
    {
        readonly IPaymentService _paymentService;

        protected ProcessWebHookService(PaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public virtual void AddInvoice()
        {
            Console.WriteLine("Process web hook service: add invoice");
            _paymentService.AddBillingInvoice();
            _paymentService.AddHistoryPayment();
        }

    }

    public class PaymentWithCredits : ProcessWebHookService
    {
        readonly ICreditsService _creditsService;
        public PaymentWithCredits(CreditsService creditsService, PaymentService paymentService) : base(paymentService)
        {
            _creditsService = creditsService;
        }


        public override void AddInvoice()
        {
            Console.WriteLine("Add invoice");
            base.AddInvoice();
            _creditsService.AddCredits(1, 20);

        }
    }
}
