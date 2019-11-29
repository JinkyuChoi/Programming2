using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Sphere
    {
        public double Length
        {
            get;
            private set;
        }

        public virtual double Volume
        {
            get { return 4.0 / 3.0 * Math.PI * Length * Length * Length; }
        }
    
        public Sphere(double length)
        {
            Length = length;
        }

        public double GetMass(double density)
        {
            double mass = Volume * density;
            return mass;
        }
    }

    public class Cylinder : Sphere
    {
        public double Height
        {
            get;
            private set;
        }

        public override double Volume
        {
            get { return Length * Length * Math.PI * Height; }
        }

        public Cylinder(double length, double height) 
            : base(length)
        {
            Sphere cylinderLength = new Sphere(length);
            Height = height;
        }
    }

    public class Cone : Cylinder
    {
        public override double Volume
        {
            get { return base.Volume * 1 / 3; }
        }

        public Cone(double length, double height) : base (length, height)
        {
            Cylinder coneLengthHeight = new Cylinder(length, height);
        }
    }
    public class Cube : Sphere
    {
        public override double Volume
        {
            get { return Length * Length * Length; }
        }

        public Cube(double length) : base(length)
        {
             Sphere cubeLength = new Sphere(length);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Sphere[] shapes = new Sphere[4];
            shapes[0] = new Sphere(2);
            shapes[1] = new Cylinder(1.5, 2);
            shapes[2] = new Cone(.75, 1.5);
            shapes[3] = new Cube(1.2);
            foreach (Sphere shape in shapes)
            {
                Console.WriteLine(shape.GetType());
                Console.WriteLine("volume={0:f2}", shape.Volume);
                Console.WriteLine();
            }

            foreach (Sphere shape in shapes)
            {
                Console.WriteLine(shape.GetType());
                Console.WriteLine("mass={0:f2}", shape.GetMass(2));
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
