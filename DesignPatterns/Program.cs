﻿// See https://aka.ms/new-console-template for more information
using DesignPatterns;
using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.Fly;
using DesignPatterns.StrategyPattern.Quack;
using DesignPatterns.Observerpattern;
using System;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.DecoratorPattern.BadExample;
using DesignPatterns.DecoratorPattern.Decorators;

// Strategy Pattern
Console.WriteLine("Hello, World!");
var simpleFlying = new SimpleFlying();
var simpleQuack = new SimpleQuack();
var myDuck = new Duck(simpleFlying, simpleQuack);
myDuck.Quack();
myDuck.Fly();


// Observer Pattern
var weatherStation = new WeatherStation() { };

var myPhoneDisplay = new PhoneDisplay(weatherStation, "Emil") { };
var myFriendsPhoneDisplay = new PhoneDisplay(weatherStation, "Anders") { };
var myMomsPhoneDisplay = new PhoneDisplay(weatherStation, "Mom") { };

weatherStation.add(myPhoneDisplay);
weatherStation.add(myFriendsPhoneDisplay);
weatherStation.add(myMomsPhoneDisplay);

// Decorator Pattern
// Not allowed since Beverage is an abstract class
// var myBeverage = new Beverage();

// I'd like to order an Espresso
var myEspresso = new Espresso();
myEspresso.getDesc();

// I'd like to add caramel to my Espresso
var myEspressoWithCaramel = new CaramelDecorator(myEspresso);
myEspressoWithCaramel.getDesc();

// I'd like to add soy to my caramel Espresso
var myEspressoWithCaramelAndSoy = new SoyDecorator(myEspressoWithCaramel);
Console.WriteLine("My drink");
myEspressoWithCaramelAndSoy.getDesc();


// I'd like to order an additional soy-caramel espresso for my friend
var myfriendsHotBeverage = new SoyDecorator(new CaramelDecorator(new Espresso()));
Console.WriteLine("My friends drink");
myfriendsHotBeverage.getDesc();


bool running = true;

static void ShowChoices()
{
    Console.WriteLine("1. Say Hello");
    Console.WriteLine("2. Say Goodbye");
    Console.WriteLine("3. Quack");
    Console.WriteLine("4. Fly");
    Console.WriteLine("5. Update all weatherapp displays about weather change");
    Console.WriteLine("s. See choices");
    Console.WriteLine("q. Exit");
}
ShowChoices();

while (running)
{
    Console.Write("(s: see choices)\nEnter your choice:");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Hello!");
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Goodbye!");
            break;
        case "3":
            Console.Clear();
            myDuck.Quack();
            break;
        case "4":
            Console.Clear();
            myDuck.Fly();
            break;
        case "5":
            Console.Clear();
            weatherStation.notify();
            break;
        case "s":
            Console.Clear();
            ShowChoices();
            break;
        case "0":
        case "q":
            running = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

    Console.WriteLine(); // Add a blank line for readability
}

Console.WriteLine("Program ended. Press any key to exit...");
//Console.ReadKey();