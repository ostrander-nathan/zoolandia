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
            public Dog(string name)
            {
                this.name = name;
            }
            public Dog(int weight)
            {
              this.weight = weight.ToString();
            }
            public Dog (string name, int weight)
            {
              this.name = name;
              this.weight = weight.ToString();
            }
            public override void FoodChoice ()
            {
                base.FoodChoice();
                Console.WriteLine("Prime Rib Only");
            }
        }

    }