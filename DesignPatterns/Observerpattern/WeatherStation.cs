using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observerpattern
{
    internal class WeatherStation : IWeatherStation
    {
        private int currentTemp = 50;
        private List<IObserver> listOfObservers = new List<IObserver>();

        // Observer methods
        public void add(IObserver objectObserving)
        {
            listOfObservers.Add(objectObserving);
        }

        public void remove(IObserver objectObserving)
        {
            listOfObservers.Remove(objectObserving);
        }

        public void notify()
        {
            foreach (var observingObject in listOfObservers)
            {
                observingObject.update();
            }
        }


        // Class-specific methods
        public void readCurrectTemp()
        {
            Console.WriteLine($"{currentTemp}C");
        }
    }
}
