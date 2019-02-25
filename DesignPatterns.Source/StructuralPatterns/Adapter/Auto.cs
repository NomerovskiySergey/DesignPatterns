using System;

namespace DesignPatterns.Source.StructuralPatterns.Adapter
{
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
}
