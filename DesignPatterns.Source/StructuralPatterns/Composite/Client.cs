using System;

namespace DesignPatterns.Source.StructuralPatterns.Composite
{
    public class Client : IClient
    {
        public void Run()
        {
            Component fileSystem = new Directory("Файловая система");
            Component diskC = new Directory("Диск С");

            Component pngFile = new File("myFoto.png");
            Component docxFile = new File("Diploma.docx");

            diskC.Add(pngFile);
            diskC.Add(docxFile);

            fileSystem.Add(diskC);
            fileSystem.Print();
            Console.WriteLine();
  
            diskC.Remove(pngFile);

            Component docsFolder = new Directory("Мои Документы");
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");

            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);

            diskC.Add(docsFolder);

            fileSystem.Print();
        }
    }
}
