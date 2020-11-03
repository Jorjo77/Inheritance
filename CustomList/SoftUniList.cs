
using System;

namespace CustomList
{
    class SoftUniList<T> : List<T> 
    {
        public override void Add(T item)
        {
            Console.WriteLine("Adding the best element since 1902" + item);
            base.Add(item); 
        }
    }
}
