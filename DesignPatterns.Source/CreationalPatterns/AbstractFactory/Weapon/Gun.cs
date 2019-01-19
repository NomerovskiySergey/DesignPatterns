using System;

namespace DesignPatterns.Source.CreationalPatterns.AbstractFactory.Weapon
{
    class Gun: IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Стреляет из пистолета");
        }
    }
}
