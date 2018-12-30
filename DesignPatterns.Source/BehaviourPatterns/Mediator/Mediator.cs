using System.Collections.Generic;

namespace DesignPatterns.Source.BehaviourPatterns.Mediator
{
    abstract class Mediator
    {
        protected Dictionary<Participant, Colleague> _map;

        public Mediator()
        {
            _map = new Dictionary<Participant, Colleague>();
        }

        public abstract void Send(Participant type, string message);

        public abstract void Setup(Participant type, Colleague colleague);
    }
}
