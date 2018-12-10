using System;

namespace DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility
{
    public class PayPalPaymentHandler: PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalPaymentHandler)
            {
                Console.WriteLine("Payment is made through the PayPal payment system");
            }
            else
            {
                Chain.Handle(receiver);
            }
        }
    }
}
