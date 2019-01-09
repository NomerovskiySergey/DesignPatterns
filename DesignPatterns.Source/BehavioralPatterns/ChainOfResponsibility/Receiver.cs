namespace DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility
{
    public class Receiver
    {
        public bool BankPayment { get; set; }
        public bool PayPalPaymentHandler { get; set; }
        public bool WesternUnionPaymentHandler { get; set; }

        public Receiver(bool bkp, bool ppp, bool wup)
        {
            BankPayment = bkp;
            PayPalPaymentHandler = ppp;
            WesternUnionPaymentHandler = wup;
        }

    }
}
