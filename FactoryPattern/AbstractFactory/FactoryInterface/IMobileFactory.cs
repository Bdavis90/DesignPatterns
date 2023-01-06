using FactoryPattern.AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile CreateMobile(ModelType modelType);
        ISignal CreateSignalStrength(ModelType modelType);
    }
}
