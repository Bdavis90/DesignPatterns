using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class Decaf : Beverage
    {
        private double price = 3.00;

        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override double Cost()
        {
            double totalPrice = price;
            totalPrice += base.Cost();
            Console.WriteLine($"The total price of the Decaf Coffee is {totalPrice}");
            return totalPrice;
        }
    }
}
