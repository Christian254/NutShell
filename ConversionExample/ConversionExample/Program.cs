using System;

namespace ConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Christian Fuentes 
            // Conversions Implicits and Explicits 
            //both kinds of conversion are prohibited
            int x = 12345; // int is a 32-bit integer
            long y = x; // Implicit conversion to 64-bit integer
            short z = (short)x; // Explicit conversion to 16-bit integer
        }
    }
}
