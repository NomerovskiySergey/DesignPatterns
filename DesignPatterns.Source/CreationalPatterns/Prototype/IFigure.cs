namespace DesignPatterns.Source.CreationalPatterns.Prototype
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}
