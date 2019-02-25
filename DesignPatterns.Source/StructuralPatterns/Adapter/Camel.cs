using System;

namespace DesignPatterns.Source.StructuralPatterns.Adapter
{
    class Camel: IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пескам пустыни");
        }
    }
}
