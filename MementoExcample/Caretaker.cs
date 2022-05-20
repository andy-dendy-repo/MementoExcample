using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExcample
{
    internal class Caretaker
    {
        private readonly List<IMemento<PictureState>> _mementos = new List<IMemento<PictureState>>();

        private readonly Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            string info = string.Join("\n",_mementos.Select(x => x.Name));

            MessageBox.Show(info);
        }
    }
}
