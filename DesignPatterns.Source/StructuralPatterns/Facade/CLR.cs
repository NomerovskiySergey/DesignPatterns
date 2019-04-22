using System;

namespace DesignPatterns.Source.StructuralPatterns.Facade
{
    class CLR: ICLR
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение приложения");
        }
        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }

    public interface ICLR
    {
        void Execute();
        void Finish();
    }
}
