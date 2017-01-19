using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Amphibia: Animal
    {
        bool toxic = false;

        public bool Toxic
        {
            get
            {
                return toxic;
            }

            set
            {
                toxic = value;
            }
        }
        
    }


}