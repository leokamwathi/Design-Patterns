using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interface
{
    interface IObserverable
    {
        List<IObserver> ObserverList { get; set; }
        int State { get; set; }

        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
