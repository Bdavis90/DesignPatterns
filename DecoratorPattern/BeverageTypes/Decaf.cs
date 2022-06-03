using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class Decaf : Beverage
    {

        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
