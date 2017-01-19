using System;
using Zoolandia.Animals;

namespace Zoolandia
{
     public class Salamander: Caudata
     {
     
         public Salamander ()
         {
             this.FavoriteFood = "Fish";
             this.scientificName = "Caudata";
             this.commonName = "Salamander";
         }
        public override void SkinType ()
        {
            // base.sleep();
            Console.WriteLine("Semi-aquatic Permeable");
        }
            public override void sleep ()
            {
                // base.sleep();
                Console.WriteLine("1 hour a day of sleep for me");
            }
        public override void movementSpeed(int movementSpeed)
        {
            Console.WriteLine(30);
        }
        }
    }
