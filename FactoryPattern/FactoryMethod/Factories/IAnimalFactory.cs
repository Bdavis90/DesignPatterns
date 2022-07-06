using FactoryPattern.FactoryMethod.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.Factories
{
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(Animal type);
    }
}
