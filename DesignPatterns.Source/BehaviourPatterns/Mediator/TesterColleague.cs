using System;

namespace DesignPatterns.Source.BehaviourPatterns.Mediator
{
    class TesterColleague : Colleague
    {
        public TesterColleague(Mediator mediator) : base(mediator)
        {
            Setup();
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение тестировщику: " + message);
        }

        protected override void Setup()
        {
            mediator.Setup(Participant.Tester, this);
        }
    }
}
