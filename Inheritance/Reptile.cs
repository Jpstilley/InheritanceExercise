using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        internal bool IsColdBlooded { get; } = true;
        internal bool HasScales { get; } = true;
        internal bool Oviparous { get; } = true;
        internal int NumberOfLungs { get; set; }


        public Reptile()
        {
            Legs = 4;
            IsVertabrate = true;
        }
    }
}
