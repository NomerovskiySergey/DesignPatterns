namespace DesignPatterns.Source.StructuralPatterns.Adapter
{
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
