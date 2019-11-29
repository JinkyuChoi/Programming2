using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Zoo : IPlace
    {
        public bool AddAnimal(IAnimal animal)
        {
            animal.Location = Location.Zoo;
            return true;
        }
    }
}
