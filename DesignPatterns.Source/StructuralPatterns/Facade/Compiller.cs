using System;

namespace DesignPatterns.Source.StructuralPatterns.Facade
{
    class Compiller: ICompiller
    {
        public void Compile()
        {
            Console.WriteLine("Компиляция приложения");
        }
    }

    interface ICompiller
    {
        void Compile();
    }
}
