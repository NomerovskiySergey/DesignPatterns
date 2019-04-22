namespace DesignPatterns.Source.StructuralPatterns.Facade
{
    class VisualStudioFacade: IIDEFacade
    {
        ITextEditor _textEditor;
        ICompiller _compiller;
        ICLR _clr;

        public VisualStudioFacade(ITextEditor te, ICompiller compil, ICLR clr)
        {
            _textEditor = te;
            _compiller = compil;
            _clr = clr;
        }
        public void Start()
        {
            _textEditor.CreateCode();
            _textEditor.Save();
            _compiller.Compile();
            _clr.Execute();
        }
        public void Stop()
        {
            _clr.Finish();
        }
    }

    interface IIDEFacade
    {
        void Start();
        void Stop();
    }
}
