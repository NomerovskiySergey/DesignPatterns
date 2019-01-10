namespace DesignPatterns.Source.CreationalPatterns.FactoryMethod
{
    class SeaLogistic: Logistic
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
