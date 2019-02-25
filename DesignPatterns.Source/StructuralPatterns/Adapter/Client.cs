using System;

namespace DesignPatterns.Source.StructuralPatterns.Adapter
{
    public class Client: IClient
    {
        public void Run()
        {
            Driver driver = new Driver();
            Auto auto = new Auto();

            driver.Travel(auto);

            Camel camel = new Camel();
            ITransport camelTransport = new Adapter(camel);

            driver.Travel(camelTransport);
        }
    }
}
