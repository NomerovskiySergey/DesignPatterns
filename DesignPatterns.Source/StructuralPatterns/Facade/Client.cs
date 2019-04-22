using System;

namespace DesignPatterns.Source.StructuralPatterns.Facade
{
    public class Client : IClient
    {
        public void Run()
        {
            ITextEditor textEditor = new TextEditor();
            ICompiller compiller = new Compiller();
            ICLR clr = new CLR();

            IIDEFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);
        }
    }
}
