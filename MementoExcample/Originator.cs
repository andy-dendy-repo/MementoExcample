using MementoExcample.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExcample
{
    internal class Originator
    {
        private PictureState _pictureState;

        public Originator(PictureState pictureState)
        {
            _pictureState = pictureState;
        }

        public void DrawPicture(Graphics graphics)
        {
            _pictureState.Draw(graphics);
        }

        public void AddFigure(IFigure figure)
        {
            _pictureState.Add(figure);
        }

        public IMemento<PictureState> Save()
        {
            return new PictureStateMemento(_pictureState.Copy());
        }

        public void Restore(IMemento<PictureState> memento)
        {
            if (!(memento is PictureStateMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            _pictureState = memento.State;
        }
    }
}
