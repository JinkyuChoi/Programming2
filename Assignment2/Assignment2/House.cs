using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class House : IPlace
    {
        public bool AddAnimal(IAnimal animal)
        {
            animal.Location = Location.House;
            return true;              
        }
    }
}
