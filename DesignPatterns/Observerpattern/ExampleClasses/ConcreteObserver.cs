using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observerpattern.ExampleClasses
{
    internal class ConcreteObserver : IObserver, IConcreteObserver
    {
        public void update()
        {
            Console.WriteLine("Observable notified");
            customObserverMethod();
        }

        public void customObserverMethod()
        {
            Console.WriteLine("customMethod functionality");
        }
    }
}
