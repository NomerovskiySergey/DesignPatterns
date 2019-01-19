using System;

namespace DesignPatterns.Source.CreationalPatterns.AbstractFactory.Weapon
{
    class Bow: IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Стреляет из лука");
        }
    }
}
