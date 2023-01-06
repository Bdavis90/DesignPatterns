using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.Product
{
    public class iPhone14 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("iPhone 14 Mobile Created");
        }
    }
}
