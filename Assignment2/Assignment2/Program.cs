using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Tiger tiger = new Tiger();           
            Pigeon pigeon = new Pigeon();
            Penguin penguin = new Penguin();

            IAnimal[] animals = new IAnimal[4];
            animals[0] = cat;
            animals[1] = tiger;
            animals[2] = pigeon;
            animals[3] = penguin;

            foreach(IAnimal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

            Zoo zoo = new Zoo();
            zoo.AddAnimal(tiger);
            zoo.AddAnimal(pigeon);
            zoo.AddAnimal(penguin);

            House house = new House();
            house.AddAnimal(cat);

            Console.WriteLine();
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

            pigeon.FlyAway();
            Console.WriteLine();
            Console.WriteLine(pigeon.ToString());

            Console.ReadKey();
           
        }
    }
}
