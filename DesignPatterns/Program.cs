// See https://aka.ms/new-console-template for more information


using DesignPatterns.Intro_To_Design_Patterns;

MallardDuck MDuck = new MallardDuck();
MDuck.Display();
MDuck.Quack();
MDuck.Swim();
MDuck.Fly();


Console.WriteLine("----------------------------------------------");

RedheadDuck RDuck = new RedheadDuck();
RDuck.Display();
RDuck.Quack();
RDuck.Swim();
RDuck.Fly();

Console.WriteLine("----------------------------------------------");

RubberDuck RubDuck = new RubberDuck();
RubDuck.Display();
RubDuck.Quack();
RubDuck.Swim();
RubDuck.Fly();

Console.WriteLine("----------------------------------------------");

DecoyDuck WDuck = new DecoyDuck();
WDuck.Display();
WDuck.Quack();
WDuck.Swim();
WDuck.Fly();

Console.ReadKey();