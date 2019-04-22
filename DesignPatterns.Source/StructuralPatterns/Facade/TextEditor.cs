using System;

namespace DesignPatterns.Source.StructuralPatterns.Facade
{
    class TextEditor: ITextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Написание кода");
        }
        public void Save()
        {
            Console.WriteLine("Сохранение кода");
        }
    }

    interface ITextEditor
    {
        void CreateCode();
        void Save();
    }
}
