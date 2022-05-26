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
            Console.WriteLine("I am a Duck");
        }

        public virtual void Quack()
        {
            Console.WriteLine("Quacking!");
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swimming!");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Flying!");
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

    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck!");
        }

        public override void Quack()
        {
            Console.WriteLine("I Squeak!");
        }

        public override void Fly()
        {
            Console.WriteLine("I don't fly. :(");
        }
    }

    public class DecoyDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("I don't quack.");
        }

        public override void Display()
        {
            Console.WriteLine("I am a Decoy Duck!");
        }

        public override void Fly()
        {
            Console.WriteLine("I don't fly. :(");
        }
    }
}
