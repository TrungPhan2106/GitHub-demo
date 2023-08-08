// See https://aka.ms/new-console-template for more information
using System;
class Car
{
    string color = "blue";
    string name = "BMW";
    int speed = 5;
    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.name);
    }
}
