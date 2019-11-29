using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class BadRectangle
    {
        public int length;
        public int width;

        public static BadRectangle CreateRectangle(int length, int width)
        {
            BadRectangle badRectangle = new BadRectangle();

            badRectangle.length = length;
            badRectangle.width = width;

            return badRectangle;
        }

        public static void DescribeBadRectangle(BadRectangle badRectangle)
        {
            Console.WriteLine("The length of the rectangle is {0}",badRectangle.length);
            Console.WriteLine("The width of the rectangle is {0}", badRectangle.width);
        }

        public static void CalculateAndDisplayArea(BadRectangle badRectangle)
        {
            int area = badRectangle.length * badRectangle.width;
            Console.WriteLine("The area of the rectangle is {0}", area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BadRectangle myRectangle = new BadRectangle();
            myRectangle = BadRectangle.CreateRectangle(4, 5);

            BadRectangle.DescribeBadRectangle(myRectangle);
            BadRectangle.CalculateAndDisplayArea(myRectangle);

            Console.ReadKey();
        }
    }
}
