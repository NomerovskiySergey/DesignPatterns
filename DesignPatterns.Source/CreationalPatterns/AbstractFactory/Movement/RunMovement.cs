using System;

namespace DesignPatterns.Source.CreationalPatterns.AbstractFactory.Movement
{
    class RunMovement: IMovement
    {
        public void Move()
        {
            Console.WriteLine("Бежит");
        }
    }
}
