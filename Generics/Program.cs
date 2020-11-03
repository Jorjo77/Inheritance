using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCard<string> cart = new StringCard<string>();
            string name = cart.Product;
        }
    }
}
