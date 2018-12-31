using System;
using DesignPatterns.Source.BehaviourPatterns;
using Chain = DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility;
using Strategy = DesignPatterns.Source.BehaviourPatterns.Strategy;
using Observer = DesignPatterns.Source.BehaviourPatterns.Observer;
using Command = DesignPatterns.Source.BehaviourPatterns.Command;
using TemplateMethod = DesignPatterns.Source.BehaviourPatterns.TemplateMethod;
using State = DesignPatterns.Source.BehaviourPatterns.State;
using Interpreter = DesignPatterns.Source.BehaviourPatterns.Interpreter;
using Mediator = DesignPatterns.Source.BehaviourPatterns.Mediator;
using Memento = DesignPatterns.Source.BehaviourPatterns.Memento;



//TO DO: need to integrate DI Container
namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client;

            client = new Memento.Client();
            client.Run();

            Console.ReadKey();
        }
    }
}
