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

                    Cat catInstance = new Cat();
                    Console.WriteLine(catInstance.name);

                    Dog dogInstance = new Dog();
                    Console.WriteLine(dogInstance.name);

                    Bird birdInstance = new Bird();
                    Console.WriteLine(birdInstance.name);

                    Cat superCat = new Cat("Sam");
                    Console.WriteLine(superCat.name);

                    Dog superDog = new Dog("Bill");
                    Console.WriteLine(superDog.name);

                    Bird superBird = new Bird("Mike");
                    Console.WriteLine(superBird.name);

                    Cat fatCat = new Cat(10);
                    Console.WriteLine(fatCat.weight);

                    Dog fatDog = new Dog(20);
                    Console.WriteLine(fatDog.weight);

                    Bird fatBird = new Bird(30);
                    Console.WriteLine(fatBird.weight);

                    Cat bigCat = new Cat("Nick", 90);
                    Console.Write(bigCat.name);
                    Console.Write(bigCat.weight); 

                    Dog bigDog = new Dog("Dave", 30);
                    Console.Write(bigDog.name);
                    Console.Write(bigDog.weight); 

                    Bird bigBird = new Bird("Ace", 50);
                    Console.Write(bigBird.name);
                    Console.Write(bigBird.weight); 

                    
                
             }

        }
        
    }