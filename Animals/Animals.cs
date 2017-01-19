using System;

 namespace Zoolandia.Animals
    {
    public class Animal : ISwimming
    {
        public string name { get; set; }
        public string height { get; set;}
        public string weight { get; set;}
        public string cutenessFactor {get; set;}
        public string signatureNoise {get; set;}
        public string isSafe {get; set;}

        
        public virtual void sleep()
        {
            Console.WriteLine("Animal is now sleeping");
        }
        public string FavoriteFood {get;set;}
        public string commonName { get; set;}
        public string scientificName {get;set;}
        public bool toxic {get;set;}

        public virtual void FoodChoice ()
        {
            Console.WriteLine("peas and carrots");
        }
         public virtual void SkinType()
        {
            Console.WriteLine("rubber");
        }
        public bool CanSwim()
        {
            return true;
        }
        public bool CanFly()
        {
            Console.WriteLine("no flying for these guys");
            return false;
        }
        public void Floats()
        {
            Console.WriteLine("Sinks Like a Rock");
        }
     
            
    }
}