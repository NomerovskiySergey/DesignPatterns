namespace DesignPatterns.Source.StructuralPatterns.Decorator
{
    abstract class Pizza
    {
        public Pizza(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
    }
}
