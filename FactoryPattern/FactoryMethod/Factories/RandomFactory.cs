using FactoryPattern.FactoryMethod.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.Factories
{
    public class RandomFactory : IAnimalFactory
    {

        public IAnimal CreateAnimal(Animal type)
        {
            throw new NotImplementedException();
        }
    }
}
