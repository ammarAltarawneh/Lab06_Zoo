using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Zoo
{
    public abstract class Mammal : Animal
    {
        public virtual string Color { get; set; }
        public Mammal(string name, int numberOfLegs, bool flyAbility, string color) : base(name, numberOfLegs, flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
            Color = color;
        }

        public Mammal(string name, int numberOfLegs, bool flyAbility) : base(name, numberOfLegs, flyAbility)
        {
        }

        public virtual void Breastfeed()
        {
            Console.WriteLine($"{Name} is breastfeed its childs.");
        }

        
    }
}
