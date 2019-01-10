using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
