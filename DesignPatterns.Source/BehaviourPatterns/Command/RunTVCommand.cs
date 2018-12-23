namespace DesignPatterns.Source.BehaviourPatterns.Command
{
    class RunTVCommand : ICommand
    {
        private TV _receiver;

        public RunTVCommand(TV receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.On();
        }

        public void Undo()
        {
            _receiver.Off();
        }
    }
}
