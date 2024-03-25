using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observerpattern
{
    internal interface IObservable
    {
        void add(IObserver objectObserving);
        void remove(IObserver objectObserving);
        void notify();
    }
}
