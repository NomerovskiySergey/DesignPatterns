using System;

namespace DesignPatterns.Source.BehaviourPatterns.Mediator
{
    class ProgrammerColleague: Colleague
    {
        public ProgrammerColleague(Mediator mediator) : base(mediator)
        {
            Setup();
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение программисту: " + message);
        }

        protected override void Setup()
        {
            mediator.Setup(Participant.Programmer, this);
        }
    }
}
