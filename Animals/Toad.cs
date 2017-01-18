using System;
using Zoolandia.Animals;

namespace Zoolandia
{
     public class Toad: Bufo
     {
     
         public Toad ()
         {
             this.FavoriteFood = "Insects and Small Animals";
             this.scientificName = "Bufo Marinus";
             this.commonName = "Marine Toad";
             this.toxic = true;
         }

        public override void sleep ()
        {
            base.sleep();
            Console.WriteLine("No sleep till Brooklyn");
        }
    }
}
