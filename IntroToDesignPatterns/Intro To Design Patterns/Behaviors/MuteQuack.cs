using IntroToDesignPatterns.Intro_To_Design_Patterns.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToDesignPatterns.Intro_To_Design_Patterns.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack.");
        }
    }
}
