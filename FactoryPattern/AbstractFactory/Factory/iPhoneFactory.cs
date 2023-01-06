using FactoryPattern.AbstractFactory.FactoryInterface;
using FactoryPattern.AbstractFactory.Product;
using FactoryPattern.AbstractFactory.ProductInterface;
using FactoryPattern.AbstractFactory.Signal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.Factory
{
    public class iPhoneFactory : IMobileFactory
    {
        public IMobile CreateMobile(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Fourteen:
                    return new iPhone14();
                case ModelType.FourteenPro:
                    return new iPhone14Pro();
                default:
                    throw new Exception("Invalid model type");
            }
        }

        public ISignal CreateSignalStrength(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Fourteen:
                    return new iPhone14Signal();
                case ModelType.FourteenPro:
                    return new iPhone14ProSignal();
                default:
                    throw new Exception("Invalid model type");
            }
        }
    }
}
