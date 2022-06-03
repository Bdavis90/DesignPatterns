using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class Espresso : Beverage
    {

        public Espresso()
        {
            description = "Expresso";
        }

        public override double Cost()
        {

            return 1.99;
        }
    }
}
