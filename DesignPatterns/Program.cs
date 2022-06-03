// See https://aka.ms/new-console-template for more information


using DecoratorPattern.BeverageTypes;
using DesignPatterns.Intro_To_Design_Patterns;
using IntroToDesignPatterns.Intro_To_Design_Patterns.Behaviors;
using ObserverPattern;
using ObserverPattern.WeatherDisplays;
using StrategyPattern.StrategyPattern;

// STRATEGY PATTERN

//Duck MDuck = new MallardDuck();
//MDuck.Display();
//MDuck.PerformQuack();
//MDuck.Swim();
//MDuck.PerformFly();
//MDuck.SetFlyBehavior(new FlyNoWay());
//MDuck.PerformFly();

//Console.WriteLine("----------------------------------------------");


//Duck ModelDuck = new ModelDuck();
//ModelDuck.Display();
//ModelDuck.PerformQuack();
//ModelDuck.Swim();
//MDuck.PerformFly();
//ModelDuck.SetFlyBehavior(new FlyRocketPowered());
//ModelDuck.PerformFly();

//Console.WriteLine("----------------------------------------------");

//RedheadDuck RDuck = new RedheadDuck();
//RDuck.Display();
//RDuck.PerformQuack();
//RDuck.Swim();
//RDuck.PerformFly();

//Console.WriteLine("----------------------------------------------");

//RubberDuck RubDuck = new RubberDuck();
//RubDuck.Display();
//RubDuck.PerformQuack();
//RubDuck.Swim();
//RubDuck.PerformFly();

//Console.WriteLine("----------------------------------------------");

//DecoyDuck WDuck = new DecoyDuck();
//WDuck.Display();
//WDuck.PerformQuack();
//WDuck.Swim();
//WDuck.PerformFly();

//Character king = new King();
//king.Fight();

//Console.WriteLine("----------------------------------------------");

//Character Queen = new Queen();
//Queen.Fight();

//Console.WriteLine("----------------------------------------------");

//Character Knight = new Knight();
//Knight.Fight();

//Console.WriteLine("----------------------------------------------");

//Character Troll = new Troll();
//Troll.Fight();


// OBSERVER PATTERN

//WeatherData weatherData = new WeatherData();

//CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
//ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
//StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

// PUSH/PULL OBSERVERS
//weatherData.MeasurementsChanged();
//weatherData.MeasurementsChanged();
//weatherData.MeasurementsChanged();
//weatherData.RemoveObserver(currentConditionsDisplay);
//weatherData.RemoveObserver(forecastDisplay);
//weatherData.RemoveObserver(statisticsDisplay);
//weatherData.MeasurementsChanged();
//weatherData.RegisterObserver(statisticsDisplay);
//weatherData.MeasurementsChanged();

//EVENT OBSERVERS
//weatherData.MeasurementsChanged();
//weatherData.MeasurementsChanged();
//weatherData.MeasurementsChanged();
//weatherData.MeasurementsChanged();
//weatherData.MeasurementsChanged();

// DECORATOR PATTERN

HouseBlend houseBlend = new HouseBlend();
houseBlend.SetMilk(true);
houseBlend.SetSoy(true);
houseBlend.Cost();


Console.ReadKey();