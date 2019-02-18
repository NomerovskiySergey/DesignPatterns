using System;
using DesignPatterns.Bootstrap;
using DesignPatterns.Source;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = Factory.GetInstance();
           IClient client = factory.GetService<IClient>(Types.ChainOfResponsibility.ToString());
           client.Run();

            Console.ReadKey();
        }
    }
}
