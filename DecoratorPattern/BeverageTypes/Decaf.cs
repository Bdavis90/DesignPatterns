using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class Decaf : IBeverage
    {

        public Decaf()
        {
            Description = "Decaf Coffee";
        }

        public string Description { get; set; }

        public double Cost() => 1.05;

        public string GetDescription() => Description;
    }
}
