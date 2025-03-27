using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    //unique property for the car
    public bool HasTrunk { get; set; } = true;
    
    // implement abstract method
    public override void DriveAbstract()
    {
        Console.WriteLine("The car is driving.");
    }
}