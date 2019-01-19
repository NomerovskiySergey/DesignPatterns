using DesignPatterns.Source.CreationalPatterns.AbstractFactory.Movement;
using DesignPatterns.Source.CreationalPatterns.AbstractFactory.Weapon;

namespace DesignPatterns.Source.CreationalPatterns.AbstractFactory.Factory
{
    class SoldierFactory: IFactory
    {
        public IWeapon CreateWeapon()
        {
            return new Gun();
        }

        public IMovement CreateMovement()
        {
           return new FlyMovement();
        }
    }
}
