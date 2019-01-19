using System;

namespace DesignPatterns.Source.CreationalPatterns.AbstractFactory.Movement
{
    class FlyMovement: IMovement
    {
        public void Move()
        {
            Console.WriteLine("Летит");
        }
    }
}
