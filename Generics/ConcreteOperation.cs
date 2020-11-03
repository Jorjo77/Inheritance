using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    //дженерик клас наследява недженерик!!!
    class ConcreteOperation<T> : Operation
    {
        public T Name { get; set; }
    }
}
