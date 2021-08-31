using System;
namespace Inheritance
{
    public class Animal
    {
        internal string animalName { get; set; }
        internal int Legs { get; set; }
        public bool IsVertabrate { get; set; }
        internal bool IsAlive { get; set; }

        public Animal()
        {
            IsAlive = true;
        }
    }
}
