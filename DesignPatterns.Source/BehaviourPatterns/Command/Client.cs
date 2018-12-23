using System.Collections.Generic;

namespace DesignPatterns.Source.BehaviourPatterns.Command
{
    public class Client : IClient
    {
        public void Run()
        {
            var initiator = new Pult();

            var tvReceiver = new TV();
            var consoleReceiver = new PlaystationConsole();


            initiator.SetCommand(new List<ICommand>()
            {
                new RunTVCommand(tvReceiver),
                new RunConsoleCommand(consoleReceiver)
            });

            //Run all - Undo All
            initiator.Run();
            initiator.UndoAll();

        }
    }
}
