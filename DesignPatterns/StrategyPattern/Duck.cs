﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.StrategyPattern.Fly;
using DesignPatterns.StrategyPattern.Quack;

namespace DesignPatterns.StrategyPattern
{
    internal class Duck : IFlyBehaviour, IQuackBehaviour
    {
        IFlyBehaviour _flyBehaviour;
        IQuackBehaviour _quackBehaviour;

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            _flyBehaviour = flyBehaviour;
            _quackBehaviour = quackBehaviour;
        }

        public void Fly()
        {
            _flyBehaviour.Fly();
        }
        public void Quack()
        {
            _quackBehaviour.Quack();
        }
    }
}
