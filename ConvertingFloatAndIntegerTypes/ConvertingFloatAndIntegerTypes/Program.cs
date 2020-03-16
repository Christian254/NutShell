using System;

namespace ConvertingFloatAndIntegerTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Christian Fuentes
            //Page 32
            int i = 1;
            float f = i;
            Console.WriteLine($"f: {f}");

            //The reverse convertion must be explicit
            int i2 = (int) f;
            Console.WriteLine($"i2: {i2}");
            //When you cast from a floating-point number to an integral
            //type, any fractional portion is truncated; no rounding is performed.
            //int to float preserves magnitude but may occasionally lose precision
            int i3 = 100000001;
            float f1 = i3; // Magnitude preserved, precision lost
            int i4 = (int)f; // 100000000
            Console.WriteLine($"i3: {i3}");
            Console.WriteLine($"f1: {f1}");
            Console.WriteLine($"i4: {i4}");
            Console.ReadKey();
            //int to decimal can be implicitly converted
            //decimal to int must be converted explicitly

        }
    }
}
