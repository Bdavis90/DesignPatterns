using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    #region Original Class
#if false

    public class Milk : CondimentDecorator
    {
        public override double Cost()
        {
            return base.Cost();
        }

        public override string GetDescription()
        {
            return base.GetDescription();
        }
    }
#endif
    #endregion

    public class Milk : IBeverage
    {
        public IBeverage beverage;
        public Milk(IBeverage beverage)
        {
            this.beverage = beverage;
            Description = "Milk";
        }

        public string Description { get; set; }

        public double Cost()
        {
            return beverage.Cost() + 0.10;
        }

        public string GetDescription()
        {
            return beverage.GetDescription() + $", {Description}";
        }
    }
}
