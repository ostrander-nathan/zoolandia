﻿using System;
using Zoolandia.Animals;

namespace Zoolandia
    {
        public class Program
        {
             public static void Main(string[] args)
             {
                 var NathansDog = new Dog();
                    NathansDog.name = "Mia";
                    NathansDog.height = "Short";
                    NathansDog.weight = "Fat";
                    NathansDog.signatureNoise = "bark";
                    NathansDog.cutenessFactor = "7";
                    NathansDog.isSafe = "true";
                    
                    NathansDog.FoodChoice();
                    Console.WriteLine(NathansDog.name);
                    Console.WriteLine($"I have a Dog named {NathansDog.name} who makes a noise that sounds like {NathansDog.signatureNoise}. I'd rate its cuteness at {NathansDog.cutenessFactor}.");
            
                var NewBird = new Bird();
                    NewBird.name = "Wanda";
                    NewBird.height = "long";
                    NewBird.weight = "skinny";
                    NewBird.signatureNoise = "chirp";
                    NewBird.cutenessFactor = "10";
                    NewBird.FoodChoice();
                    Console.WriteLine($"I have a Bird named {NewBird.name} who makes a noise that sounds like {NewBird.signatureNoise}. I'd rate its cuteness at {NewBird.cutenessFactor}.");

                var NewCat = new Cat();
                    NewCat.name = "Wynonna";
                    NewCat.height = "5ft tall";
                    NewCat.weight = "morbidly obese";
                    NewCat.signatureNoise = "meow";
                    NewCat.cutenessFactor = "1";
                    NewCat.FoodChoice();
                    Console.WriteLine($"I have a Cat named {NewCat.name} who makes a noise that sounds like {NewCat.signatureNoise}. I'd rate its cuteness at {NewCat.cutenessFactor}.");
                
                var UnknownAnimal = new Animal();
                    UnknownAnimal.FoodChoice();

                    Cat animalInstance = new Cat();
                    Console.WriteLine(animalInstance.name);

                    Dog animalInstance1 = new Dog();
                    Console.WriteLine(animalInstance1.name);

                    Bird animalInstance2 = new Bird();
                    Console.WriteLine(animalInstance2.name);
                
             }

        }
        
    }