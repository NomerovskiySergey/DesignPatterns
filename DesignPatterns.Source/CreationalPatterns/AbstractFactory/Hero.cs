using System;

namespace DesignPatterns.Source.CreationalPatterns.AbstractFactory
{
    class Hero
    {
        private IWeapon _weapon;
        private IMovement _movement;
        public Hero(IFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }

        public void Hit()
        {
            _weapon.Hit();
        }

        public void Move()
        {
            _movement.Move();
        }
    }
}
