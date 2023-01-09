// See https://aka.ms/new-console-template for more information


using AdapterPattern;
using CommandPattern;
using CommandPattern.Commands;
using CommandPattern.Receivers;
using DecoratorPattern;
using DecoratorPattern.BeverageTypes;
using DecoratorPattern.Decorators;
using DesignPatterns.Intro_To_Design_Patterns;
using FactoryPattern.AbstractFactory;
using FactoryPattern.AbstractFactory.Factory;
using FactoryPattern.AbstractFactory.ProductInterface;
using FactoryPattern.FactoryMethod.Animals;
using FactoryPattern.FactoryMethod.Factories;
using IntroToDesignPatterns.Intro_To_Design_Patterns.Behaviors;
using ObserverPattern;
using ObserverPattern.WeatherDisplays;
using SingletonPattern;
using StrategyPattern.StrategyPattern;
using System.Globalization;
using System.Text;
using System.Threading;

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

// ORIGINAL BAD CODE
//HouseBlend houseBlend = new HouseBlend();
//houseBlend.SetMilk(true);
//houseBlend.SetSoy(true);
//houseBlend.Cost();

//IBeverage espresso = new Espresso();
//espresso = new Mocha(espresso);
//Console.WriteLine($"{espresso.GetDescription()} ${espresso.Cost()}");

//IBeverage darkRoast = new DarkRoast();
//darkRoast = new Mocha(darkRoast);
//darkRoast = new Mocha(darkRoast);
//darkRoast = new Whip(darkRoast);
//Console.WriteLine($"{darkRoast.GetDescription()} ${darkRoast.Cost()}");

//IBeverage decaf = new Milk(new Milk(new Whip(new Soy(new Decaf()))));
//Console.WriteLine($"{decaf.GetDescription()} ${decaf.Cost().ToString("N", CultureInfo.InvariantCulture)}");

// FACTORY PATTERN

//BalancedFactory factory = new BalancedFactory();
//IAnimal animal = factory.CreateAnimal(Animal.Cat);

//animal.Speak();
//animal = factory.CreateAnimal(Animal.Dog);
//animal.Speak();

// ABSTRACT FACTORY PATTERN


//SamsungFactory samsungFactory = new SamsungFactory();
//IMobile galaxy = samsungFactory.CreateMobile(FactoryPattern.ModelType.Galaxy);
//galaxy.GetMobile();
//ISignal galaxySignal = samsungFactory.CreateSignalStrength(FactoryPattern.ModelType.Galaxy);
//galaxySignal.ShowSignalStrength();

//Singleton s = Singleton.GetInstance();
//Singleton s1 = Singleton.GetInstance();

//Console.WriteLine($"s hash {s.GetHashCode()}");
//Console.WriteLine($"s1 hash {s1.GetHashCode()}");


// COMMAND PATTERN

////Invoker will be passed a command
//RemoteControl remote = new RemoteControl();
//// Receiver of the request
//Light livingRoomLight = new Light("Living Room");
//Light kitchenLight = new Light("Kitchen");
//GarageDoor garageDoor = new GarageDoor();
//Stereo stereo = new Stereo();
//CeilingFan ceilingFan = new CeilingFan("Living Room");
////Command will be passed a receiver
//LightOnCommand livingRoomlightOn = new LightOnCommand(livingRoomLight);
//LightOffCommand livingRoomlightOff = new LightOffCommand(livingRoomLight);
//LightOnCommand kitchenlightOn = new LightOnCommand(kitchenLight);
//LightOffCommand kitchenlightOff = new LightOffCommand(kitchenLight);

//GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);
//GarageDoorCloseCommand garageClosed = new GarageDoorCloseCommand(garageDoor);

//StereoOnCommand stereoOn = new StereoOnCommand(stereo);
//StereoOffCommand stereoOff = new StereoOffCommand(stereo);

//CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
//CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
//CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
//CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

//remote.SetCommand(0, livingRoomlightOn, livingRoomlightOff);
//remote.SetCommand(1, kitchenlightOn, kitchenlightOff);
//remote.SetCommand(2, garageOpen, garageClosed);
//remote.SetCommand(3, stereoOn, stereoOff);
//remote.SetCommand(4, ceilingFanHigh, ceilingFanOff);
//remote.SetCommand(5, ceilingFanMedium, ceilingFanOff);
//remote.SetCommand(6, ceilingFanLow, ceilingFanOff);

//Console.WriteLine(remote.ToString());

//remote.OnButonWasPushed(0);
//remote.OffButtonWasPushed(0);
//remote.UndoButtonWasPushed();
//Console.WriteLine();
//remote.OnButonWasPushed(1);
//remote.OffButtonWasPushed(1);
//remote.UndoButtonWasPushed();
//remote.OnButonWasPushed(2);
//remote.OffButtonWasPushed(2);
//remote.UndoButtonWasPushed();
//remote.OnButonWasPushed(3);
//remote.OffButtonWasPushed(3);
//remote.UndoButtonWasPushed();
//remote.OnButonWasPushed(4);
//remote.OffButtonWasPushed(4);
//remote.UndoButtonWasPushed();
//remote.OnButonWasPushed(5);
//remote.OffButtonWasPushed(5);
//remote.UndoButtonWasPushed();
//remote.OnButonWasPushed(6);
//remote.OffButtonWasPushed(6);
//remote.UndoButtonWasPushed();

// Target
EnemyTank enemyTank = new EnemyTank();
// Adaptee
EnemyRobot robot = new EnemyRobot();
// Adapter
EnemyRobotAdapter robotAdapter = new EnemyRobotAdapter(robot);

enemyTank.AssignDriver("Brandon");
enemyTank.FireWeapon();
enemyTank.DriveForward();

robotAdapter.AssignDriver("Brandon");
robotAdapter.FireWeapon();
robotAdapter.DriveForward();


Console.ReadKey();



