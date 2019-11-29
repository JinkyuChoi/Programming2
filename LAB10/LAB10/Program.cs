using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10
{
    class Program
    {
        private static readonly IEnumerable<User> _users = new List<User>()
        {
            new User() { UserID = 1, Name = "John", Age = 13 },
            new User() { UserID = 2, Name = "Michelle", Age = 21 },
            new User() { UserID = 3, Name = "Bill", Age = 18 },
            new User() { UserID = 4, Name = "Roger", Age = 20 },
            new User() { UserID = 5, Name = "Rob", Age = 15 },
            new User() { UserID = 6, Name = "Steve", Age = 15 },
            new User() { UserID = 8, Name = "Zoe", Age = 23 },
            new User() { UserID = 9, Name = "Randel", Age = 56 },
            new User() { UserID = 10, Name = "Joshua", Age = 7 }
        };

        static void Main(string[] args)
        {
            //Q1
            Console.WriteLine("Teenagers");
            IEnumerable<User> teenageQuery =
                from u in _users
                where u.Age > 12 && u.Age < 20
                select u;

            foreach (var user in teenageQuery)
                Console.WriteLine(user);

            Console.WriteLine();

            //Q2
            Console.WriteLine("Teenagers");
            IEnumerable <User> teenageMethod = _users
                .Where(u => u.Age > 12 && u.Age < 20);

            foreach (var user in teenageMethod)
                Console.WriteLine(user);

            Console.WriteLine();

            //Q3
            Console.WriteLine("Name with N");
            IEnumerable<User> nName = _users
                .Where(u => u.Name.ToUpper().Contains('N'));

            foreach (var user in nName)
                Console.WriteLine(user);

            Console.WriteLine();

            //Q4
            Console.WriteLine("Youngest");
            var youngestUser = _users
                .Single(u => u.Age == _users.Min(uu => uu.Age));
                

            Console.WriteLine(youngestUser);

            Console.WriteLine();

            //Q5
            Console.WriteLine("Longest Name");
            var longestName = _users
                .Single(u => u.Name.Length == _users.Max(uu => uu.Name.Length));

            Console.WriteLine(longestName);

            Console.WriteLine();

            //Q6
            Console.WriteLine("Age Order");
            IEnumerable<User> ageOrder = _users
                .OrderBy(u => u.Age);

            foreach (var user in ageOrder)
                Console.WriteLine(user);

            Console.WriteLine();

            //Q7
            Console.WriteLine("Recently Added");
            IEnumerable<User> recentOrder = _users
                .OrderByDescending(u => u.UserID);

            foreach (var user in recentOrder)
                Console.WriteLine(user);

            Console.WriteLine();

            //Q8
            Console.WriteLine("Formatted List");
            IEnumerable<string> formatedList = _users
                .Select(u => $"{u.Name}({u.UserID})");

            foreach (var user in formatedList)
                Console.WriteLine(user);

            Console.WriteLine();
        }
    }
}
