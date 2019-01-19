namespace DesignPatterns.Source.CreationalPatterns.AbstractFactory
{
    interface IFactory
    {
        IWeapon CreateWeapon();
        IMovement CreateMovement();
    }
}
