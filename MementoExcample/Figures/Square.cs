using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExcample.Figures
{
    internal class Square : IFigure
    {
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Square(int x, int y)
        {
            X = x;
            Y = y;
            Width = new Random().Next(20, 70);
        }

        public Square(int x, int y, int width)
        {
            X = x;
            Y = y;
            Width = width;
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color.Red), X, Y, Width, Width);
        }

        public IFigure Copy()
        {
            return new Square(X, Y, Width);
        }
    }
}
