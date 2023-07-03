using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Zoo
{
    public class Hen : Bird
    {
        public override int Speed { get; set; }
        public Hen(string name, int numberOfLegs, bool flyAbility, int speed) : base(name, numberOfLegs, flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
            Speed = speed;
        }

        public override string Eat()
        {
            return $"{Name} feeds on small small seeds and brid.";
        }

        public override string Living()
        {
            return $"{Name} live in farms";
        }

        public override string Sleep()
        {
            return $"{Name} sleep in the farms";
        }

        public override string Sound()
        {
            return $"{Name} emits a sound like baq baq.!";
        }
    }
}
