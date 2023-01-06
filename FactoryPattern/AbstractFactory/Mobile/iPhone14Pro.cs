using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.Product
{
    public class iPhone14Pro : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("iPhone 14 Pro Mobile Created");
        }
    }
}
