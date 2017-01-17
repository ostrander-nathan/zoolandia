using System;
using Zoolandia.Animals;

namespace Zoolandia
    {
        public class Bird: Animal
        {
            public Bird()
            {
                this.name = "MyBird";
            }
            public override void FoodChoice ()
            {
                Console.WriteLine("Popcorn");
            }
        }

    }