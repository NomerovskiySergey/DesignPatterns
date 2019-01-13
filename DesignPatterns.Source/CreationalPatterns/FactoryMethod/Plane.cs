using System;

namespace DesignPatterns.Source.CreationalPatterns.FactoryMethod
{
    class Plane: ITransport
    {
        public void RunDelivery()
        {
            Console.WriteLine("Run delivery by plane");
        }
    }
}
