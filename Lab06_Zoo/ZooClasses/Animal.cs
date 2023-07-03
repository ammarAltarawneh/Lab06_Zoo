using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Zoo
{
    public abstract class Animal  
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public bool FlyAbility { get; set; }

        public Animal(string name, int numberOfLegs, bool flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
        }

        public abstract string Eat();
        public abstract string Sound();
        public abstract string Sleep();
        public abstract string Living();
    }

}
