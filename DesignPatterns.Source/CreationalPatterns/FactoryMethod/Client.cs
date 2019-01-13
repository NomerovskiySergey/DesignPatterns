using System;
using DesignPatterns.Source.BehaviourPatterns;

namespace DesignPatterns.Source.CreationalPatterns.FactoryMethod
{
    public class Client : IClient
    {
        public void Run()
        {
            var logistic = new RoadLogistic();
            var transport = logistic.CreateTransport();

            transport.RunDelivery();
        }
    }
}
