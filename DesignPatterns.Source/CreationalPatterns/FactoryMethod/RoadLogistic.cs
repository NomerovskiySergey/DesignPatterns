namespace DesignPatterns.Source.CreationalPatterns.FactoryMethod
{
    class RoadLogistic: Logistic
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
