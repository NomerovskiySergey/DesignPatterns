using System;

namespace DesignPatterns.Source.StructuralPatterns.Decorator
{
    public class Client : IClient
    {
        public void Run()
        {
            Pizza italianPizza = new ItalianPizza();
            italianPizza = new TomatoPizza(italianPizza);
            italianPizza = new CheesePizza(italianPizza);
            Console.WriteLine("Название: {0}", italianPizza.Name);
            Console.WriteLine("Цена: {0}", italianPizza.GetCost());

            Pizza bulgerianPizza = new BulgerianPizza();
            bulgerianPizza = new TomatoPizza(bulgerianPizza);
            bulgerianPizza = new CheesePizza(bulgerianPizza);
            Console.WriteLine("Название: {0}", bulgerianPizza.Name);
            Console.WriteLine("Цена: {0}", bulgerianPizza.GetCost());

            Console.ReadLine();
        }
    }
}
