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

    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
    }
}
