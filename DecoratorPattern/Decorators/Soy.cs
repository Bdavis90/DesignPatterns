using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    #region Original Class
#if false
    public class Soy : CondimentDecorator
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

    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
