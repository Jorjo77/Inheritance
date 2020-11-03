using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Child : Person // като кажем на класа че е sealed вече класа бейби не може да наследява Child  и ВиЕса ни го подчертава и изписва.  
    {
        public int Age { get; set; }
        public sealed override void Sleep()//Като кажем на метода sealed никой надолу няма да може да го override -ва.
        {
            Console.WriteLine("Dreaming for fayries");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
            base.Sleep();
        }
    }
}
