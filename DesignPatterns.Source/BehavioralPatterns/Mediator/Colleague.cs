namespace DesignPatterns.Source.BehaviourPatterns.Mediator
{
    abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(Participant type, string message)
        {
            mediator.Send(type, message);
        }
        public abstract void Notify(string message);
        protected abstract void Setup();
    }
}
