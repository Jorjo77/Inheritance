using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowingMembers
{
    public class SoftUniList<T> : List<T>
    {
        public void Add(T item)
        {
            Console.WriteLine("Adding the best element since 1902" + item);
            base.Add(item); //това е базовата функционалност на листа (с base я викаме)!!! miner в лаптопа!?
        }
    }
}
