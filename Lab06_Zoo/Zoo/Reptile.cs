using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Zoo
{
    public abstract class Reptile : Animal
    {
        public virtual string SkinSoftness { get; set; }
        public Reptile(string name, int numberOfLegs, bool flyAbility, string skinSoftness) : base(name, numberOfLegs, flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
            SkinSoftness = skinSoftness;
        }

        public Reptile(string name, int numberOfLegs, bool flyAbility) : base(name, numberOfLegs, flyAbility)
        {
        }

        public virtual void SharpTeeth()
        {
            Console.WriteLine("These reptiles has sharp Teeth");
        }
        
    }
}
