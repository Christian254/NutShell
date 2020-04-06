using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            if (5 < 2 * 3)
            {
                Console.WriteLine("true");
                Console.WriteLine("Let's move on!");
            }
            if (2 + 2 == 5)
                Console.WriteLine("Does not compute");
            else
                if (2 + 2 == 4)
                Console.WriteLine("Computes"); // Computes

        }
    }
}
