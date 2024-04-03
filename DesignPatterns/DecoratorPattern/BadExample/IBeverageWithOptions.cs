using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.BadExample
{
    internal interface IBeverageWithOptions : IBeverage
    {
        bool hasMilk();
        bool hasSoy();
        bool hasCaramel();
        bool hasWhippedCream();
    }
}
