using System;

namespace DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility
{
    public class BankPaymentHandler: PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankPayment)
            {
                Console.WriteLine("Payment is made through a bank");
            }
            else
            {
                Chain.Handle(receiver);
            }
        }
    }
}
