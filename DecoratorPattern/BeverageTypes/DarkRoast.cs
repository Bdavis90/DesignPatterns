using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class DarkRoast : IBeverage
    {

        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public string Description { get; set; }

        public double Cost() => .99;

        public string GetDescription() => Description;
    }
}
