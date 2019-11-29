﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Cat : Feline
    {
        public override bool IsWild()
        {
            bool wilderness;
            if (Location == Location.Wild)
            {
                wilderness = true;
            }
            else
            {
                wilderness = false;
            }

            return wilderness;
        }
        public override string MakeSound()
        {
            return "Meow";
        }
        public Cat() : base("Cat")
        {
            ;
        }
    }
}