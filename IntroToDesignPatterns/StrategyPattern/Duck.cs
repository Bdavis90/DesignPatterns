using IntroToDesignPatterns.Intro_To_Design_Patterns.Behaviors;
using IntroToDesignPatterns.Intro_To_Design_Patterns.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Intro_To_Design_Patterns
{
    //The Strategy Pattern defines a family of algorithms, 
    //encapsulates each one, 
    //and makes them interchangeable.
    //Strategy lets the algorithm vary independently from clients that use it.
    #region Original Classes #1
#if false
    // Bad. Increases maintenance
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

#endif
    #endregion

    #region Interface Class #2 Part 1
#if false

    public class Duck
    {
        public virtual void Display()
        {
            Console.WriteLine("I am a Duck");
        }

        public void Swim()
        {
            Console.WriteLine("Swimming!");
        }

    }


    public class MallardDuck : Duck, Flyable, Quackable
    {
        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck!");
        }

        public void Fly()
        {
            Console.WriteLine("Flying like a Mallard Duck!");
        }

        public void Quack()
        {
            Console.WriteLine("Quacking like a Mallard Duck!");
        }
    }

    public class RedheadDuck : Duck, Flyable, Quackable
    {
        public override void Display()
        {
            Console.WriteLine("I am a Redhead Duck!");
        }

        public void Fly()
        {
            Console.WriteLine("Flying like a Mallard Duck!");
        }

        public void Quack()
        {
            Console.WriteLine("Quacking like a Mallard Duck!");
        }
    }

    public class RubberDuck : Duck, Quackable
    {
        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck!");
        }

        public void Quack()
        {
            Console.WriteLine("I Squeak!");
        }

    }

    public class DecoyDuck : Duck
    {

        public override void Display()
        {
            Console.WriteLine("I am a Decoy Duck!");
        }


    }
#endif

    #endregion

    #region Interface Class #2 Part 2
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("Swimming!");
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

    }


    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck!");
        }


    }

    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Redhead Duck!");
        }

    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck!");
        }


    }

    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Decoy Duck!");
        }

    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Model Duck!");

        }
    }
    #endregion

}
