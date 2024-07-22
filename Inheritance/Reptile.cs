using System;

namespace Inheritance;

public class Reptile : Animal
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    public string ColdBlooded { get; set; }
    public string Scales { get; set; }
    public string ShortLegs { get; set; }
    public string LongTails { get; set; }

    public void TypeReptile()
    {
        ColdBlooded = "Unlike most animals reptiles are cold blooded!";
        Scales = "Reptiles also don't have skin or fur we have scales";
        ShortLegs = "They have legs, but very short ones";
        LongTails = "and we also have tails usually long ones";
    }

    public void RepInfo()
    {
        Console.WriteLine($"{ColdBlooded}. {Scales}. {ShortLegs} {LongTails}");
    }
}