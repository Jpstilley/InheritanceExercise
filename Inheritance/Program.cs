using System;

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

            Bird penguin = new Bird();
            penguin.animalName = "Penguin";
            penguin.CanFly = false;
            penguin.HasHollowBones = false;

            Console.WriteLine($"The revered {penguin.animalName}:\nHas feathers:" +
                              $" {penguin.HasFeathers}\nCan fly: {penguin.CanFly}" +
                              $"\n Has hollow bones: {penguin.HasHollowBones}" +
                              $"Has a beak: {penguin.HasBeak}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile alligator = new Reptile();
            alligator.animalName = "Alligator";
            alligator.NumberOfLungs = 2;

            Console.WriteLine($"The friedly {alligator.animalName}:\nHas {alligator.NumberOfLungs}\n" +
                              $"Has {alligator.Legs}\nIs a vertribrate: {alligator.IsVertabrate}\n" +
                              $"Is coldblooded: {alligator.IsColdBlooded}\n Is oviparous: {alligator.Oviparous}");


           

            
        }
    }
}
