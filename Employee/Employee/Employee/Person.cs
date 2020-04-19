﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }

        public void sayName()
        {
            Console.WriteLine("Name: " + firstName +  " " + lastName + " ID: " + ID);
            Console.ReadLine();
        }
    }
}
