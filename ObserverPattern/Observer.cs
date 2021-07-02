using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interface;

namespace ObserverPattern
{
    class Observer : IObserver
    {
        string Name { get; set; }
        IObserverable Observerable { get; set; }

        public Observer(IObserverable observable,string name)
        {
            Name = name;
            Observerable = observable;
            Observerable.Add(this);
        }

        public void Update()
        {
            Console.WriteLine("   " + Name + "    :  " + Observerable.State);
        }
    }
}
