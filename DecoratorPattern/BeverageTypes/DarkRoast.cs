using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class DarkRoast : Beverage
    {
        private double price = 3.50;

        public DarkRoast()
        {
            description = "DarkRoast Coffee";
        }

        public override double Cost()
        {
            double totalPrice = price;
            totalPrice += base.Cost();
            Console.WriteLine($"The total price of the DarkRoast Coffee is {totalPrice}");
            return totalPrice;
        }
    }
}
