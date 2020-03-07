using System;

namespace firstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12 * 30;
            Console.WriteLine(x);
            Console.WriteLine(FeetToInches(12));
            Console.WriteLine(FeetToInches(100));
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
