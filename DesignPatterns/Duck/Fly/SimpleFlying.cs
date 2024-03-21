using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Duck.Fly
{
    internal class SimpleFlying : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying normally");
        }
    }
}
