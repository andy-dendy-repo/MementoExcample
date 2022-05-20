using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExcample
{
    internal interface IMemento<TState>
    {
        public string Name { get; }

        public TState State { get; }

        public DateTime Date { get; }
    }
}
