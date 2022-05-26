using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Intro_To_Design_Patterns
{
    public class Duck
    {
        public virtual void Display()
        {

        }

        public void Quack()
        {
            Console.WriteLine("Quacking!");
        }

        public void Swim()
        {
            Console.WriteLine("Swimming!");
        }
    }






    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck!");
        }
    }

    public class RedheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a Redhead Duck!");
        }
    }
}
