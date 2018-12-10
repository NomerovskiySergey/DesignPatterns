using System;

namespace DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility
{
    public class WesternUnionPaymentHandler: PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.WesternUnionPaymentHandler)
            {
                Console.WriteLine("Payment is made through the Western Union payment system");
            }
            else
            {
                Chain.Handle(receiver);
            }
        }
    }
}
