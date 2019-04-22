namespace DesignPatterns.Source.StructuralPatterns.Flyweight
{
    abstract class House
    {
        protected int stages;
        public abstract void Build(double longitude, double latitude);
    }
}
