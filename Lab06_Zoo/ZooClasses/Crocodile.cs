using Lab06_Zoo.ZooInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Zoo
{
    public class Crocodile : Reptile, IMigration, ILifeSpan
    {
        public override string SkinSoftness { get; set; }
        public int MigrationDestance { get ; set ; }
        public int LifeSpanPeriod { get ; set; }

        public Crocodile(string name, int numberOfLegs, bool flyAbility, string skinSoftness) : base(name, numberOfLegs, flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
            SkinSoftness = skinSoftness;
        }

        public override string Eat()
        {
            return $"{Name} feeds on fish, birds, and mammals near the water.";
        }

        public override string Living()
        {
            return $"{Name} is commonly found in freshwater habitats";
        }

        public override string Sleep()
        {
            return $"{Name} often rests and sunbathes on the banks of rivers or lakes";
        }

        public override string Sound()
        {
            return $"{Name} produces low-frequency vocalizations!";
        }

        public void MigrationHapit()
        {
            Console.WriteLine($"The crocodile {Name} isn't typically known for migration," +
                $" as he stay all the time either in the rever or around it");
        }

        public void LifeSpan()
        {
            Console.WriteLine($"The crocodile {Name} has a life span about {LifeSpanPeriod} years");
        }
    }
}
