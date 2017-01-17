using System;
using Zoolandia.Animals;
 namespace Zoolandia
    {
      public class Cat: Animal
        {
            public Cat()
            {
                this.name = "MyCat";
            }
            public override void FoodChoice ()
            {
              Console.WriteLine("Chicken Nuggets only");
            }
        }

    }