using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("In the person construktor");
        }
        private bool gender = true;
        public string Name { get; set; }
        public int Age { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Sleeping!!!");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
