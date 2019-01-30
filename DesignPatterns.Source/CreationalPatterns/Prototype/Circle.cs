using System;

namespace DesignPatterns.Source.CreationalPatterns.Prototype
{
    class Circle : IFigure
    {
        int _radius;
        public Circle(int radius)
        {
            _radius = radius;
        }

        public IFigure Clone()
        {
            return new Circle(_radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0}", _radius);
        }
    }
}
