using System.Collections.Generic;

namespace DesignPatterns.Source.BehaviourPatterns.Command
{
    interface IInitiator
    {
        void SetCommand(List<ICommand> commands);
    }
}
