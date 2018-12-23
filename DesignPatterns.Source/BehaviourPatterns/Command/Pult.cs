using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Source.BehaviourPatterns.Command
{
    class Pult: IInitiator
    {
        private List<ICommand> _commands;
        private Stack<ICommand> _commandsHistory;

        public Pult()
        {
            _commands = new List<ICommand>()
            {
                new NoCommand()
            };

            _commandsHistory = new Stack<ICommand>();
        }

        public void SetCommand(List<ICommand> commands)
        {
            _commands = commands;
        }

        public void Run(int? commandNumber = null)
        {
            if (commandNumber.HasValue)
            {
                var command = _commands[commandNumber.Value];

                command.Execute();
                _commandsHistory.Push(command);
            }
            else
              {
                _commands.ForEach((c) =>
                {
                    c.Execute();
                    _commandsHistory.Push(c);
                });
                
            }
        }

        public void UndoLast()
        {
            _commandsHistory.Pop().Undo();
        }

        public void UndoAll()
        {
            foreach (var item in _commandsHistory)
            {
                item.Undo();
            }

            _commandsHistory.Clear();
        }
    }
}
