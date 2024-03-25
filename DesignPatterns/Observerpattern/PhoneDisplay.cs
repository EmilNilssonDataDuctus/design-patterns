using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observerpattern
{
    internal class PhoneDisplay : IObserver, IDisplay
    {
        private WeatherStation _myObservable;
        private string _owner;

        public PhoneDisplay(WeatherStation observable, string owner)
        {
            this._myObservable = observable;
            this._owner = owner;
        }

        public void update()
        {
            this.display();
        }

        public void display()
        {
            Console.WriteLine($"{_owner}s phone: New weather just dropped!");
            _myObservable.readCurrectTemp();
        }
    }
}
