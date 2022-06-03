using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public abstract string GetDescription();
    }
}
