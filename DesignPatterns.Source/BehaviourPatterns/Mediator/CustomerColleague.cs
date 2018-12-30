using System;

namespace DesignPatterns.Source.BehaviourPatterns.Mediator
{
    class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) : base(mediator)
        {
            Setup();
        }
        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение заказчику: " + message);
        }

        protected override void Setup()
        {
            mediator.Setup(Participant.Customer, this);
        }
    }
}
