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
            public Cat(string name)
            {
                this.name = name;
            }
            public Cat(int weight)
            {
              this.weight = weight.ToString();
            }
            public Cat (string name, int weight)
            {
              this.name = name;
              this.weight = weight.ToString();
            }
            public override void FoodChoice ()
            {
              Console.WriteLine("Chicken Nuggets only");
            }
        }

    }