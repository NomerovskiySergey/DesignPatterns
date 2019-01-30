using System;
using DesignPatterns.Source.BehaviourPatterns;

namespace DesignPatterns.Source.CreationalPatterns.Prototype
{
    public class Client: IClient
    {
        public void Run()
        {
            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
        }
    }
}
