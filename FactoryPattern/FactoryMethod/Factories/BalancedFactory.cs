using FactoryPattern.FactoryMethod.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.Factories
{
    public class BalancedFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(Animal type)
        {
            IAnimal animal = null;
            switch (type)
            {
                case Animal.Cat:
                    animal = new Cat();
                    break;
                case Animal.Dog:
                    animal = new Dog();
                    break;
                default:
                    break;
            }

            return animal;
        }


    }
       public enum Animal
        {
            Cat,
            Dog
        }
}
