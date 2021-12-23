using System;
using System.Collections.Generic;

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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.WingColor = "yellow";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 2.5;

            Console.WriteLine($"Alive:{true}");
            Console.WriteLine($"Age: 0 years old");
            Console.WriteLine($"It has 2 legs");
            Console.WriteLine($"It lives by air");
            Console.WriteLine();

            var lizard = new Reptile();
            lizard.IsColdBlooded = true;
            lizard.IsScaly = true;
            lizard.Habitat = "Swamp";
            lizard.CanGrowTail = true;

            Console.WriteLine($"Alive:{true}");
            Console.WriteLine($"Age: 0 years old");
            Console.WriteLine($"It has 4 legs");
            Console.WriteLine($"It lives by land");

     



            var myAnimals = new Animal[] { };

            foreach(var Animal in myAnimals) 
            {
                Console.WriteLine($"Alive:{Animal.IsAlive}");
                Console.WriteLine($"Age:{Animal.Age} years old");
                Console.WriteLine($"It has{Animal.LegCount}legs");
                Console.WriteLine($"It lives by{Animal.LandSeaAir}");
                Console.WriteLine($"");
            }



        }
    }
}
