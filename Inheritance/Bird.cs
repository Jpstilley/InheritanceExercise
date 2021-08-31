using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        internal bool HasFeathers { get; } = true;
        internal bool CanFly { get; set; }
        internal bool HasBeak { get; } = true;
        internal bool HasHollowBones { get; set; }

        public Bird()
        {
            Legs = 2;
            IsVertabrate = true;

        }
    }
}
