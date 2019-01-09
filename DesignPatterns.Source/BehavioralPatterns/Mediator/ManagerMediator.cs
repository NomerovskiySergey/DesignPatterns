namespace DesignPatterns.Source.BehaviourPatterns.Mediator
{
    class ManagerMediator: Mediator
    {
        public override void Send(Participant type, string message)
        {
            _map[type].Notify(message);
        }
        public override void Setup(Participant type, Colleague colleague)
        {
            _map.Add(type, colleague);
        }
    }
}
