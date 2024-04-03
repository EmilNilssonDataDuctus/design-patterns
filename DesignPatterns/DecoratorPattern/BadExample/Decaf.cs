using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.BadExample
{
    internal class Decaf : Beverage, IBeverage
    {
        public new void cost()
        {
            Console.WriteLine("This decaf beverage costs less than you might think due to it's lower caffeine concentrate");
        }
    }
}
