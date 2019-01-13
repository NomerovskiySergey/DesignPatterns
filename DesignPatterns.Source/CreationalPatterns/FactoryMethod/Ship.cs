using System;

namespace DesignPatterns.Source.CreationalPatterns.FactoryMethod
{
    class Ship: ITransport
    {
        public void RunDelivery()
        {
            Console.WriteLine("Run delivery by ship");
        }
    }
}
