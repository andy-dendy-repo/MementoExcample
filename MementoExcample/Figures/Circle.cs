using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExcample.Figures
{
    internal class Circle : IFigure
    {
        public int Radius { get; set; }
        public int X { get; set; }
        public int Y { get; set ; }

        public Circle(int x, int y)
        {
            X = x;
            Y = y;
            Radius = new Random().Next(20,70);
        }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color.Green), X, Y, Radius, Radius);
        }

        public IFigure Copy()
        {
            return new Circle(X, Y, Radius);
        }
    }
}
