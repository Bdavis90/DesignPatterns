// See https://aka.ms/new-console-template for more information


using DesignPatterns.Intro_To_Design_Patterns;
using IntroToDesignPatterns.Intro_To_Design_Patterns.Behaviors;

Duck MDuck = new MallardDuck();
MDuck.Display();
MDuck.PerformQuack();
MDuck.Swim();
MDuck.PerformFly();
MDuck.SetFlyBehavior(new FlyNoWay());
MDuck.PerformFly();

Console.WriteLine("----------------------------------------------");


Duck ModelDuck = new ModelDuck();
ModelDuck.Display();
ModelDuck.PerformQuack();
ModelDuck.Swim();
MDuck.PerformFly();
ModelDuck.SetFlyBehavior(new FlyRocketPowered());
ModelDuck.PerformFly();

Console.WriteLine("----------------------------------------------");

RedheadDuck RDuck = new RedheadDuck();
RDuck.Display();
RDuck.PerformQuack();
RDuck.Swim();
RDuck.PerformFly();

Console.WriteLine("----------------------------------------------");

RubberDuck RubDuck = new RubberDuck();
RubDuck.Display();
RubDuck.PerformQuack();
RubDuck.Swim();
RubDuck.PerformFly();

Console.WriteLine("----------------------------------------------");

DecoyDuck WDuck = new DecoyDuck();
WDuck.Display();
WDuck.PerformQuack();
WDuck.Swim();
WDuck.PerformFly();

Console.ReadKey();