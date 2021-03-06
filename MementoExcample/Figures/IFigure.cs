using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExcample.Figures
{
    internal interface IFigure
    {
        public int X { get; set; }

        public int Y { get; set; }

        public void Draw(Graphics graphics);

        public IFigure Copy();
    }
}
