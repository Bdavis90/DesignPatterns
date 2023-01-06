using FactoryPattern.AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.Signal
{
    internal class iPhone14ProSignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("iPhone 14 Pro has great signal!");
        }
    }
}
