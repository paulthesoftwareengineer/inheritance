using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            // Bird class that inherits from Animal class
            // with 4 specific members
                class Bird : Animal
          {
             public string FeatherColor { get; set; }
             public string SingingAbility { get; set; }
             public bool CanFly { get; set; }
             public string NestType { get; set; }
          }

          // Reptile class that inherits from Animal class
          // with 4 specific members
             class Reptile : Animal
          {
             public string SkinType { get; set; }
             public bool IsVenomous { get; set; }
             public string HabitatType { get; set; }
             public string DefenseMechanism { get; set; }
          }

            class Program
          {
            static void Main(string[] args)
          {
        // Create an object of the Bird class
        Bird bird = new Bird
        {
            Name = "Eagle",
            Age = 10,
            Habitat = "Mountains",
            Diet = "Carnivorous",
            FeatherColor = "Brown",
            SingingAbility = "Good",
            CanFly = true,
            NestType = "Aerie"
        };

        // Creatively display the class member values of the bird object
        Console.WriteLine("Bird Information:");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Name: {bird.Name}");
        Console.WriteLine($"Age: {bird.Age}");
        Console.WriteLine($"Habitat: {bird.Habitat}");
        Console.WriteLine($"Diet: {bird.Diet}");
        Console.WriteLine($"Feather Color: {bird.FeatherColor}");
        Console.WriteLine($"Singing Ability: {bird.SingingAbility}");
        Console.WriteLine($"Can Fly: {bird.CanFly}");
        Console.WriteLine($"Nest Type: {bird.NestType}");
        Console.WriteLine();

        // Create an object of the Reptile class
        Reptile reptile = new Reptile
        {
            Name = "Crocodile",
            Age = 15,
            Habitat = "Wetlands",
            Diet = "Carnivorous",
            SkinType = "Scaly",
            IsVenomous = false,
            HabitatType = "Freshwater",
            DefenseMechanism = "Bite"
        };

        // Creatively display the class member values of the reptile object
        Console.WriteLine("Reptile Information:");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Name: {reptile.Name}");
        Console.WriteLine($"Age: {reptile.Age}");
        Console.WriteLine($"Habitat: {reptile.Habitat}");
        Console.WriteLine($"Diet: {reptile.Diet}");
        Console.Write
