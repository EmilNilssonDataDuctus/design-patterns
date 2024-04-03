using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    internal interface IBeverage
    {
        void getDesc();
        int cost();
    }
}
