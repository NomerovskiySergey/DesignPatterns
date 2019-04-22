namespace DesignPatterns.Source.StructuralPatterns.Decorator
{
    class ItalianPizza: Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
}
