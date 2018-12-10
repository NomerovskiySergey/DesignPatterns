namespace DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility
{
    public abstract class PaymentHandler
    {
        public PaymentHandler Chain { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
