// See https://aka.ms/new-console-template for more information
using DesignPatterns;
using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.Fly;
using DesignPatterns.StrategyPattern.Quack;
using DesignPatterns.Observerpattern;
using System;

Console.WriteLine("Hello, World!");

var myDuck = new Duck(new SimpleFlying(), new SimpleQuack());
myDuck.Quack();

var weatherStation = new WeatherStation() { };

var myPhoneDisplay = new PhoneDisplay(weatherStation, "Emil") { };
var myFriendsPhoneDisplay = new PhoneDisplay(weatherStation, "Anders") { };
var myMomsPhoneDisplay = new PhoneDisplay(weatherStation, "Mom") { };

weatherStation.add(myPhoneDisplay);
weatherStation.add(myFriendsPhoneDisplay);
weatherStation.add(myMomsPhoneDisplay);


bool running = true;

Console.WriteLine("1. Say Hello");
Console.WriteLine("2. Say Goodbye");
Console.WriteLine("3. Quack");
Console.WriteLine("4. Fly");
Console.WriteLine("5. Update all weatherapp displays about weather change");
Console.WriteLine("0. Exit");

while (running)
{
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Hello!");
            break;
        case "2":
            Console.WriteLine("Goodbye!");
            break;
        case "3":
            myDuck.Quack();
            break;
        case "4":
            myDuck.Fly();
            break;
        case "5":
            weatherStation.notify();
            break;
        case "0":
            running = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

    Console.WriteLine(); // Add a blank line for readability
}

Console.WriteLine("Program ended. Press any key to exit...");
//Console.ReadKey();