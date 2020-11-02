using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class FactoryWorker : Worker
    {
        public FactoryWorker()//тук след като имаме в workar празен конструктор, C# автоматично ще си го приеме 
        {
            Console.WriteLine("In the factory worker construktor");
        }

        public FactoryWorker(string factoryCompany)
            :base(factoryCompany)
        {
            Console.WriteLine("In the factory worker construktor");
        }
        public void LeaveFactory()
        {
            Console.WriteLine("Leave");
        }
    }
}
