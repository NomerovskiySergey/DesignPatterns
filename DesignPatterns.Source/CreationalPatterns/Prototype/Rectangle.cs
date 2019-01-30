using System;

namespace DesignPatterns.Source.CreationalPatterns.Prototype
{
    class Rectangle: IFigure
    {

        int _width;
        int _height;
        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public IFigure Clone()
        {
            return new Rectangle(_width, _height);
        }

        public void GetInfo()
        {
            Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", _height, _width);
        }
    }
}
