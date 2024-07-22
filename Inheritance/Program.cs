using System;
using System.Transactions;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            var animal = new Animal();
            animal.Legs = 3;
            animal.Arms = 10;
            animal.Mouth = "I have a small mouth";
            animal.SkinOrFur = "I have fur";

            Console.WriteLine(" ");
            animal.TypeOfAnimal();
            Console.WriteLine();
            
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird = new Bird();
 
            bird.Beak = "Birds have beaks instead of a mouth";
            bird.Wings = "Birds have wings";
            bird.HollowBones = "Birds are the only animals that have hollow bones in order to fly";
            bird.Feathers = "They are have feather instead of skin or fur";
            
            Console.WriteLine();
            bird.DiffBird();
            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            var reptile = new Reptile();

            reptile.ColdBlooded = "Reptiles are cold blooded";
            reptile.Scales = "They also have scales instead of fur";
            reptile.ShortLegs = "Reptiles have legs, but short ones";
            reptile.LongTails = "While they have legs, there usually short";
            
            Console.WriteLine();
            reptile.RepInfo();


        }
    }
}
