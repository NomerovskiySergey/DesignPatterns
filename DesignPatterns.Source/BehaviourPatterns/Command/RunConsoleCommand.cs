namespace DesignPatterns.Source.BehaviourPatterns.Command
{
    class RunConsoleCommand: ICommand
    {
        private PlaystationConsole _console;
        public RunConsoleCommand(PlaystationConsole console)
        {
            _console = console;
        }
        public void Execute()
        {
            _console.On();
        }

        public void Undo()
        {
            _console.Off();
        }
    }
}
