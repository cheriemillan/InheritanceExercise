
using System;

namespace Inheritance;

public class Bird : Animal
{
    
    
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    public string Beak { get; set; }
    public string Wings { get; set; }
    public string Feathers { get; set; }
    public string HollowBones { get; set; }
    
    public void BirdInfo()
    {
        Beak = "Birds have a beak as a mouth";
        Wings = "While birds also have legs they mostly use two wings to fly in order to travel";
        Feathers = "Birds have feathers which isn't of skin or fur";
        HollowBones = "In order to fly they need to have hollow bones";
    }


    public void DiffBird()
    {
        Console.WriteLine($"{Beak}, unlike most animals.{Wings}. Another thing is birds are the only creature that have feathers. {Feathers}. {HollowBones}");
    }
    
}