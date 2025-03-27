using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    //unique property for motorcycle
    public bool HasSideCart { get; set; } = false;
    
    //implement abstract method
    public override void DriveAbstract()
    {
        Console.WriteLine("The motorcycle is driving down the road.");
    }
    //override virtual method
    public override void DriveVirtual()
    {
        Console.WriteLine("The motorcycleis roaring through the streets.");
        
    }
}