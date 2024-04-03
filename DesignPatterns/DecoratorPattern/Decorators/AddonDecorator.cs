using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    internal abstract class AddonDecorator : Beverage, IBeverage
    {
        public override int cost()
        {
            return 2;
        }
    }
}
