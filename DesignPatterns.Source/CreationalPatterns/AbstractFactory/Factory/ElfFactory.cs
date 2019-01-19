using DesignPatterns.Source.CreationalPatterns.AbstractFactory.Movement;
using DesignPatterns.Source.CreationalPatterns.AbstractFactory.Weapon;

namespace DesignPatterns.Source.CreationalPatterns.AbstractFactory.Factory
{
    class ElfFactory: IFactory
    {
        public IWeapon CreateWeapon()
        {
            return new Bow();
        }

        public IMovement CreateMovement()
        {
            return new RunMovement();
        }
    }
}
