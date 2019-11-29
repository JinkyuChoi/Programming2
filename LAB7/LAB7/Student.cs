using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab08
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentNumber { get; set; }

        public Student(string name, int studentNumber)
        {
            Name = name;
            StudentNumber = studentNumber;
        }
        public override string ToString()
        {
            return $"Name : {Name} , Student Number : {StudentNumber}";
        }
    }
}
