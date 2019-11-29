﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Product(int id, string name, float price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID = {ID}, Name = {Name}, Price = {Price}";
        }
    }
}