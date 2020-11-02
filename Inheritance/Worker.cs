using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Worker : Person
    {
        public Worker()
        {
            Console.WriteLine("In the empty worker constructor");
        }
        public Worker(string companyName)
        {
            Company = companyName;
            Console.WriteLine("In the worker construktor");
        }
        public string Company { get; set; }
        public bool IsLazy { get { return true; } }
    }
}
