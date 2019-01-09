using System;

namespace DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility
{
    public class Client: IClient
    {
        private PaymentHandler _bankPaymentHandler;
        private PaymentHandler _paypalPaymentHandler;
        private PaymentHandler _westernunionPaymentHandler;
        Receiver _receiver;

        public Client()
        {
            _receiver = new Receiver(false, false, true);

            _bankPaymentHandler = new BankPaymentHandler();
            _paypalPaymentHandler = new PayPalPaymentHandler();
            _westernunionPaymentHandler = new WesternUnionPaymentHandler();


            _bankPaymentHandler.Chain = _paypalPaymentHandler;
            _paypalPaymentHandler.Chain = _westernunionPaymentHandler;
        }

        public void Run()
        {
            _bankPaymentHandler.Handle(_receiver);
        }
    }
}
