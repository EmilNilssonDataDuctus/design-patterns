using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.BadExample
{
    internal abstract class Beverage : IBeverage
    {
        public void getDesc()
        {
            Console.WriteLine("This is one hell of a beverage");
        }
        public void cost()
        {
            Console.WriteLine("This beverage costs what it costs");
        }
    }
}
