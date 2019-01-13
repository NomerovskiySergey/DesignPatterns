using System;

namespace DesignPatterns.Source.CreationalPatterns.FactoryMethod
{
    class Truck: ITransport
    {
        public void RunDelivery()
        {
            Console.WriteLine("Run delivery by truck");
        }
    }
}
