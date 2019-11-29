using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Animal : IAnimal
    {
        public Location Location
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract bool IsWild();

        public abstract int LegCount();

        public abstract string MakeSound();

        public override string ToString()
        {
            return string.Format("The {0} goes {1} in the {2}", Name, MakeSound(), Location);
        }
    }
}
