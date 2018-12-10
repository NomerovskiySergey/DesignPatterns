using System;
using DesignPatterns.Source.BehaviourPatterns;
using DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chain Of Responsibility
            IClient client = new Client();
            client.Run();

            //Startegy

            Console.ReadKey();
        }
    }
}
