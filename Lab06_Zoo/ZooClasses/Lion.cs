using Lab06_Zoo.ZooInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Zoo
{
    public class Lion : Mammal, ILifeSpan
    {
        public override string Color { get; set; }

        private string NeckName { get; set; }
        
        public int LifeSpanPeriod { get ; set; } //Interface property

        public Lion(string name, int numberOfLegs, bool flyAbility, string color, string neckName) : base(name, numberOfLegs, flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
            Color = color;
            NeckName = neckName;
        }

        public override string Eat()
        {
            return $"{Name} eating meats so they are Carnivores";
        }

        public override string Living()
        {
            return  $"{Name} lives in grasslands, savannas, open woodlands";
        }

        public override string Sleep()
        {
            return $"{Name} sleep under the Trees";
        }

        public override string Sound()
        {
            return $"{Name} Roars Loudly!";
        }

        public string NeckHair()
        {
            return $"{Name} has a hair on his neck";
        }

        public void LifeSpan()  // Interface method
        {
            Console.WriteLine($"The Lion {Name} has a life span about {LifeSpanPeriod} years");
        }
    }
}
