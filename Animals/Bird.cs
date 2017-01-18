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
            public Bird(string name)
            {
                this.name = name;
            }
            public Bird(int weight)
            {
              this.weight = weight.ToString();
            }
            public Bird (string name, int weight)
            {
              this.name = name;
              this.weight = weight.ToString();
            }
            public override void FoodChoice ()
            {
                base.FoodChoice();
                Console.WriteLine("Popcorn");
            }
        }

    }