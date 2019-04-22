namespace DesignPatterns.Source.StructuralPatterns.Decorator
{
    abstract class PizzaDecorator: Pizza
    {
        protected Pizza pizza;

        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this.pizza = pizza;
        }
    }
}
