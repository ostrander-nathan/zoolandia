using System;

 namespace Zoolandia.Animals
    {
    public class Animal 
    {
        public string name { get; set; }
        public string  height { get; set;}
        public string weight { get; set;}
        public string cutenessFactor {get; set;}
        public string signatureNoise {get; set;}
        public string isSafe{get; set;}

            public virtual void FoodChoice ()
            {
                Console.WriteLine("peas and carrots");
            }
        
            public static void sleep ()
            {
                // Console.WriteLine("Animal is now sleeping");

            }
    }
}