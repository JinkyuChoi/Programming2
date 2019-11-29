using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1(); DivideByZeroException
            try
            {
                Console.WriteLine("Executing Question1 Method :");
                Question1();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Exception Thrown : {ex.Message}");
            }

            Console.WriteLine();

            //Question2(); IndexOutOfRangeException
            try
            {
                Console.WriteLine("Executing Question2 Method :");
                Question2();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception Thrown : {ex.Message}");
            }

            Console.WriteLine();

            //Question3(); FileNotFoundException
            try
            {
                Console.WriteLine("Executing Question3 Method :");
                Question3();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine($"Exception Thrown : {ex.Message}");
            }

            Console.WriteLine();

            //Question4(); FormatException
            try
            {
                Console.WriteLine("Executing Question4 Method :");
                Question4();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception Thrown : {ex.Message}");
            }

            Console.WriteLine();

            //Question5(); NullReferenceException
            try
            {
                Console.WriteLine("Executing Question5 Method :");
                Question5();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Exception Thrown : {ex.Message}");
            }

            Console.WriteLine();

            //Question7(); ThrowException
            try
            {
                Console.WriteLine("Executing Question7 Method :");
                Console.Write("Do you want to throw an Exception? ( y / n ) : ");
                string answer = Console.ReadLine().ToLower();
                Question7(answer);
            }
            catch (ThrowException ex)
            {
                Console.WriteLine($"Exception Thrown : {ex.Message}");
            }
            Console.ReadKey();
        }
        public static void Question1()
        {
            int num = 0;
            int value = 1 / num;
            Console.WriteLine(value);
        }
        public static void Question2()
        {
            char[] letters = new[] { 'a', 'b', 'c' };
            char letterFour = letters[3];
            Console.WriteLine(letterFour);
        }
        public static void Question3()
        {
            System.IO.File.ReadAllText("badfile");
        }
        public static void Question4()
        {
            Convert.ToBoolean("not a boolean");
        }
        public static void Question5()
        {
            string nullString = null;
            nullString.ToString();
        }
        public static void Question7(string answer)
        {
            if(answer == "y")
            {
                throw new ThrowException("Exception Thrown from Question7 Method");
            }
        }
    }
}
