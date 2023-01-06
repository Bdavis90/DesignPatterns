using FactoryPattern.AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.Signal
{
    public class SamsungGalaxySignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Samsung Galaxy has great signal!");

        }
    }
}
