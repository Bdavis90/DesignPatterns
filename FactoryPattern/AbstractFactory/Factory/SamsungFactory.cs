using FactoryPattern.AbstractFactory.FactoryInterface;
using FactoryPattern.AbstractFactory.Product;
using FactoryPattern.AbstractFactory.ProductInterface;
using FactoryPattern.AbstractFactory.Signal;

namespace FactoryPattern.AbstractFactory.Factory
{
    public class SamsungFactory : IMobileFactory
    {
        public IMobile CreateMobile(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Galaxy:
                    return new SamsungGalaxy();
                case ModelType.A9:
                    return new SamsungA9();
                default:
                    throw new Exception("Invalid model type"); ;
            }
        }

        public ISignal CreateSignalStrength(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Galaxy:
                    return new SamsungGalaxySignal();
                case ModelType.A9:
                    return new SamsungA9Signal();
                default:
                    throw new Exception("Invalid model type"); ;
            }
        }
    }
}
