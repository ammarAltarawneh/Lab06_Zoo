using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab06_Zoo.Zoo
{

    public abstract class Bird : Animal
    {
        public virtual int Speed { get; set; }
        public Bird(string name, int numberOfLegs, bool flyAbility, int speed) : base(name, numberOfLegs, flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
            Speed = speed;
        }

        public Bird(string name, int numberOfLegs, bool flyAbility) : base(name, numberOfLegs, flyAbility)
        {
        }

        public virtual void DisplayWingSize()
        {
            Console.WriteLine("Size Of the Birds Wings");

        }

    }
}
