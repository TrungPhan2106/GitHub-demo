// See https://aka.ms/new-console-template for more information
using System;
class Car
{
    string color = "red";
    string name = "BMW";

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.name);
    }
}
