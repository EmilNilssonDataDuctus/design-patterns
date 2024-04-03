using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    internal class SoyDecorator : AddonDecorator
    {
        Beverage _beverage;

        public SoyDecorator(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override int cost()
        {
            return _beverage.cost() + 2;
        }
    }
}
