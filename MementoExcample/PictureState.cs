using MementoExcample.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExcample
{
    internal class PictureState
    {
        public List<IFigure> Figures { get; set; } = new List<IFigure>();

        public void Add(IFigure figure)
        {
            Figures.Add(figure);
        }

        public PictureState Copy()
        {
            PictureState copy = new PictureState()
            {
                Figures = Figures.Select(x => x.Copy()).ToList()
            };

            return copy;
        }

        public void Draw(Graphics graphics)
        {
            foreach(var item in Figures)
            {
                item.Draw(graphics);
            }
        }
    }
}
