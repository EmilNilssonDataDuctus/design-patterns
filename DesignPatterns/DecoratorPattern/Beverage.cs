using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    internal abstract class Beverage : IBeverage
    {

        public void getDesc()
        {
            Console.WriteLine("Cost: " + this.cost());
        }
        public abstract int cost();
    }
}
