using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExcample
{
    internal class PictureStateMemento : IMemento<PictureState>
    {
        private readonly PictureState _pictureState;
        private readonly DateTime _date;

        public PictureStateMemento(PictureState pictureState)
        {
            _pictureState = pictureState;
            _date = DateTime.Now;
        }

        public DateTime Date
        {
            get=> _date;
        }

        public string Name
        {
            get => $"Picture with {_pictureState.Figures.Count} pictures";
        }

        public PictureState State
        {
            get => _pictureState;
        }
    }
}
