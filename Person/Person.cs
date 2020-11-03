using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        public virtual void Sleep()//с virtual даваме възможност детето да не спи comfortably (да оверрайдне метода)
        {
            Console.WriteLine("Sleeping comfortably");
        }
    }
}
