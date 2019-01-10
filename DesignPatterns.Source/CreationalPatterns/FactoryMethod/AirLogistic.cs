namespace DesignPatterns.Source.CreationalPatterns.FactoryMethod
{
    class AirLogistic: Logistic
    {
        public override ITransport CreateTransport()
        {
            return new Plane();
        }
    }
}
