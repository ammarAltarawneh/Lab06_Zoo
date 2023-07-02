using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Zoo
{
    public class Sheep : Mammal
    {
        public override string Color { get; set; }
        private int NipplesNum { get; set; }
        public Sheep(string name, int numberOfLegs, bool flyAbility, string color, int nipplesNum) : base(name, numberOfLegs, flyAbility)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            FlyAbility = flyAbility;
            Color = color;
            NipplesNum = nipplesNum;
        }

        public override string Eat()
        {
            return $"{Name} eating seeds and grass";
        }

        public override string Living()
        {
            return $"{Name} live in farms among people";
        }

        public override string Sleep()
        {
            return $"{Name} sleep inside a barn";
        }

        public override string Sound()
        {
            return $"{Name} sounds Baa!";
        }

        public bool EatAbility()
        {
            return true;
        }
    }
}
