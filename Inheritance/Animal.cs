using System;

namespace Inheritance;

public class Animal
{
    // Create a class Animal
    // give this class 4 members that all Animals have in common
    public int Arms {get; set;}
    public int Legs {get;set;}
    public string Mouth { get; set; }
    public string SkinOrFur { get; set; }

    public Animal()
    {
        Arms = 4;
        Legs = 4;
        Mouth = "a mouth with teeth";
        SkinOrFur = "most animals have fur or skin";

    }

    public void TypeOfAnimal()
    {
        Console.WriteLine($"Hello I have {Arms} arms, {Legs} legs, have {Mouth}, and {SkinOrFur}");
    }
    
}