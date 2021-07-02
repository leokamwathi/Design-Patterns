using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interface;

namespace ObserverPattern
{
    class Observerable : IObserverable
    {
        public List<IObserver> ObserverList { get; set; }
        public int State { get; set; }

        public Observerable()
        {
            ObserverList = new List<IObserver>();
        }



        public void Add(IObserver observer)
        {
            ObserverList.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            ObserverList.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in ObserverList )
            {
                observer.Update();
            }
        }
    }
}
