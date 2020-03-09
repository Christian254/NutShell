using System;

namespace TypeBasicsBool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Christian Fuentes
            //Type Basics, Bool. Page 21
            bool simpleVar = false;
            if (simpleVar)
            {
                Console.WriteLine("This will not print");
            }
            int x = 5000;
            bool lessThanAMile = x < 5280;
            if (lessThanAMile)
            {
                Console.WriteLine("This will print");
            }
        }
    }
}
