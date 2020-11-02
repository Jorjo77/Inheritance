using System;

namespace ShadowingMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            TennisEvent tennisEvent = new TennisEvent();
            tennisEvent.Print();
            Console.WriteLine(tennisEvent.Duration);
            tennisEvent.Start();
            SoftUniList<int> softUniList = new SoftUniList<int>();
            softUniList.Add(5);
            softUniList.Add(5);
            softUniList.Add(5);

        }
    }
}
