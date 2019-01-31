using System;
using DesignPatterns.Source.BehaviourPatterns;

namespace DesignPatterns.Source.CreationalPatterns.Singleton
{
    public class Client: IClient
    {
        public void Run()
        {
            Console.WriteLine($"Main {DateTime.Now.TimeOfDay}");

            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.Name);
        }
    }
}
