using System;

namespace DesignPatterns.Source.BehaviourPatterns.Mediator
{
    public class Client: IClient
    {
        public void Run()
        {
            ManagerMediator mediator = new ManagerMediator();
            Colleague customer = new CustomerColleague(mediator);
            Colleague programmer = new ProgrammerColleague(mediator);
            Colleague tester = new TesterColleague(mediator);

            customer.Send(Participant.Programmer, "Есть заказ, надо сделать программу");
            programmer.Send(Participant.Tester, "Программа готова, надо протестировать");
            tester.Send(Participant.Customer, "Программа протестирована и готова к продаже");
        }
    }
}
