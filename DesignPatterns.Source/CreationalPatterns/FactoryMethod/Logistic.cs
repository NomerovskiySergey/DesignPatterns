namespace DesignPatterns.Source.CreationalPatterns.FactoryMethod
{
    abstract class Logistic
    {
        public void Delivery()
        {
            var transport = CreateTransport();
            transport.RunDelivery();
        }

        public abstract ITransport CreateTransport();
    }
}
