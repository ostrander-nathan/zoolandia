using System;
using Zoolandia.Animals;

 namespace Zoolandia
    {
        public class Dog: Animal
        {
            public Dog()
            {
                this.name = "MyDog";
            }
            public override void FoodChoice ()
            {
                Console.WriteLine("Prime Rib Only");
            }
        }

    }