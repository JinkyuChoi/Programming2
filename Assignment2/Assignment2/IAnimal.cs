using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IAnimal
    {
        Location Location
        {
            get;
            set;
        }

        bool IsWild();
        int LegCount();
        string MakeSound();
    }
}
