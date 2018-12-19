using System;
using DesignPatterns.Source.BehaviourPatterns;
using Chain = DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility;
using Strategy = DesignPatterns.Source.BehaviourPatterns.Strategy;
using Observer = DesignPatterns.Source.BehaviourPatterns.Observer;

//TO DO: need to integrate DI Container
namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client;

            //Chain Of Responsibility
            //IClient client = new Chain.Client();
            //client.Run();

            //Strategy
            //client = new Strategy.Client();
            //client.Run();

            //Observer
            client = new Observer.Client();
            client.Run();

            Console.ReadKey();
        }
    }
}
