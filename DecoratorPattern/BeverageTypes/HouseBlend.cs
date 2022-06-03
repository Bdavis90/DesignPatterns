using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class HouseBlend : Beverage
    {
        private double price = 3.25;

        public HouseBlend()
        {
            description = "HouseBlend Coffee";
        }

        public override double Cost()
        {
            double totalPrice = price;
            totalPrice += base.Cost();
            Console.WriteLine($"The total price of the HouseBlend Coffee is {totalPrice}");
            return totalPrice;
        }
    }
}
