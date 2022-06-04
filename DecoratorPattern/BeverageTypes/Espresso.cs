using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class Espresso : IBeverage
    {

        public Espresso()
        {
            Description = "Expresso";
        }

        public string Description { get; set; }

        public double Cost() => 1.99;

        public string GetDescription() => Description;
    }
}
