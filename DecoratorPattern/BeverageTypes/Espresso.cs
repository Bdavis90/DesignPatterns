using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class Espresso : Beverage
    {

        private double price = 3.25;

        public Espresso()
        {
            description = "Expresso Coffee";
        }

        public override double Cost()
        {
            double totalPrice = price;
            totalPrice += base.Cost();
            Console.WriteLine($"The total price of the Expresso Coffee is {totalPrice}");
            return totalPrice;
        }
    }
}
