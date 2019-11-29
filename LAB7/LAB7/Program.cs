using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            // List Lab //
            List<string> days = new List<string>()
                { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("Days List");
            DisplayCollection(days);
            Console.WriteLine();


            days.Remove("Wednesday");

            Console.WriteLine("Days List (Remove Wednesday)");
            DisplayCollection(days);
            Console.WriteLine();

            Console.WriteLine("Check DrewDay :");
            if (!days.Contains("DrewDay"))
            { Console.WriteLine("DrewDay is not here"); }
            Console.WriteLine();


            days.Sort();

            Console.WriteLine("Days List (Sorted)");
            DisplayCollection(days);
            Console.WriteLine();

            Console.WriteLine("Press any key to go to the next Lab");
            Console.ReadKey();
            Console.Clear();

            // Queue Lab //
            Queue<string> names1 = new Queue<string>(new[] { "Alex", "Alisa", "Atila" });

            Console.WriteLine("Names1 Queue");
            DisplayCollection(names1);
            Console.WriteLine();


            names1.Enqueue("Ahmad");

            Console.WriteLine("Names1 Queue (Enqueue Ahmad)");
            DisplayCollection(names1);
            Console.WriteLine();

            Console.WriteLine("Names1 Dequeued :");
            Console.WriteLine(names1.Dequeue());
            Console.WriteLine(names1.Dequeue());
            Console.WriteLine();

            Console.WriteLine("Names1 Queue (After Dequeue)");
            DisplayCollection(names1);
            Console.WriteLine();

            Console.WriteLine("Press any key to go to the next Lab");
            Console.ReadKey();
            Console.Clear();

            // Stack
            Stack<string> names2 = new Stack<string>(new[] { "Billy", "Bale", "Beth" });

            Console.WriteLine("Names2 Stack");
            DisplayCollection(names2);
            Console.WriteLine();


            names2.Push("Brian");

            Console.WriteLine("Names2 Stack (Push Brian)");
            DisplayCollection(names2);
            Console.WriteLine();

            Console.WriteLine("Names2 Poped :");
            Console.WriteLine(names2.Pop());
            Console.WriteLine(names2.Pop());
            Console.WriteLine();

            Console.WriteLine("Names2 Stack (After Pop)");
            DisplayCollection(names2);
            Console.WriteLine();

            Console.WriteLine("Press any key to go to the next Lab");
            Console.ReadKey();
            Console.Clear();

            // Dictionary
            Dictionary<int, Student> studentsID = new Dictionary<int, Student>()
            {
                { 12345, new Student("Alice",12345) },
                { 67890, new Student("Bob", 67890) },
                { 13579, new Student("Charlie", 13579) },
                { 24680, new Student("Dennis",24680) },
                { 99999, new Student("Erin", 99999)}
            };

            Console.WriteLine("Key and Student Info Dictionary");
            DisplayCollection(studentsID);
            Console.WriteLine();

            Console.WriteLine("Search Student 13579");
            Console.WriteLine(studentsID[13579]);
            Console.WriteLine();

            studentsID.Remove(24680);

            Console.WriteLine("Key and Student Info Dictionary (After Remove 24680)");
            DisplayCollection(studentsID);
            Console.WriteLine();

            Console.WriteLine("Press any key to end the Lab");
            Console.ReadKey();
        }

        public static void DisplayCollection(IEnumerable values)
        {
            foreach (var value in values)
            {
                Console.WriteLine($"{value} ");
            }
        }
    }
}