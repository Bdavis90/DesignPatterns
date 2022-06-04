using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public abstract class CondimentDecorator : IBeverage
    {
        public IBeverage beverage;

        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Cost()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        //public abstract string GetDescription();
    }
}
