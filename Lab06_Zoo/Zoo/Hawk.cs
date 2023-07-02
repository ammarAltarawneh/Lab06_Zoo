using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Zoo
{
    internal class Hawk : Bird
    {
        public override int Speed { get; set; }
        private double BeakLength { get; set; }
        public Hawk(string name, int numberOfLegs, bool flyAbility, int speed, double beakLength) : base(name, numberOfLegs, flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
            Speed = speed;
            BeakLength = beakLength;
        }

        public override string Eat()
        {
            return $"{Name} feeds on small animals and fish.";
        }

        public override string Living()
        {
            return $"{Name} live in forests and mountains";
        }

        public override string Sleep()
        {
            return $"{Name} rests and sleeps perched on high branches or cliffs";
        }

        public override string Sound()
        {
            return $"{Name} emits a high-pitched screech or whistle as its vocalization.!";
        }
        public string Beak()
        {
            return $"{Name}'s Beak Length about {BeakLength}Cm";
        }
    }
}
