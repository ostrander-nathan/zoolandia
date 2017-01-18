using System;
using Zoolandia.Animals;

namespace Zoolandia
{
     public class Frog: Anura
     {
     
         public Frog ()
         {
             this.FavoriteFood = "Insects";
             this.scientificName = "Hyla";
             this.commonName = "Tree Frog";
         }

        public override void SkinType ()
        {
            // base.sleep();
            Console.WriteLine("Permeable");
        }
        public override void sleep ()
        {
            // base.sleep();
            Console.WriteLine("Up All Night!");
        }
        public override void sleepHours(int sleepHours)
        {
            Console.WriteLine(17);
        }
      }
}
