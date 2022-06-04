using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public class HouseBlend : IBeverage
    {

        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public string Description { get; set; }

        public double Cost() => .89;

        public string GetDescription() => Description;
    }
}
