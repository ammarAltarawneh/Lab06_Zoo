using Lab06_Zoo.ZooInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Zoo
{
    public class Snake : Reptile, IMigration
    {
        public override string SkinSoftness { get; set; }
        public int MigrationDestance { get ; set ; } //Interface property

        public Snake(string name, int numberOfLegs, bool flyAbility, string skinSoftness) : base(name, numberOfLegs, flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
            SkinSoftness = skinSoftness;
        }

        public override string Eat()
        {
            return $"{Name} feeds on small mammals, birds, and reptiles.";
        }

        public override string Living()
        {
            return $"{Name} inhabits various environments including forests, grasslands, and deserts";
        }

        public override string Sleep()
        {
            return $"{Name} rests in hidden areas such as burrows or vegetation";
        }

        public override string Sound()
        {
            return $"{Name} produces hissing sounds when threatened!";
        }
        public string ShedSkin()
        {
            return $"{Name} periodically sheds its skin as it grows.";
        }

        public void MigrationHapit() // Interface method
        {
            Console.WriteLine($"The snake {Name} isn't typically known for long-distance migrations," +
                $" but in some occasions she imigrate about {MigrationDestance} Km");
        }
    }
}
