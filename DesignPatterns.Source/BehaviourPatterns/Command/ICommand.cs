namespace DesignPatterns.Source.BehaviourPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
