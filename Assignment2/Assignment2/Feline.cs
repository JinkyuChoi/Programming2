using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Feline : Animal
    {
        public Feline(string name) : base(name)
        {
            Name = name;
        }
        public override int LegCount()
        {
            return 4;
        }
    }
}
