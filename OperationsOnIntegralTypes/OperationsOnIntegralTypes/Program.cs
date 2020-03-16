using System;

namespace OperationsOnIntegralTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Christian Fuentes
            //Page 34 - 35 - 36

            //Division

            //Division operations on integral types always truncate remainders(round toward zero).
            //int a = 2 / 3; // 0 
            //int b = 0;
            //int c = 5 / b; // throws DivideByZeroException

            //OverFlow

            //int a = int.MinValue;
            //a--;
            //Console.WriteLine(a == int.MaxValue); // True


            //Overflow check operators
            //int a = 1000000;
            //int b = 1000000;
            //int c = checked(a * b); // Checks just the expression.
            //checked // Checks all expressions
            //{ 
            //    // in statement block.
            //    c = a * b;
            //}

            //Unchecked 
            //int x = int.MaxValue;
            //int y = unchecked(x + 1);
            //unchecked 
            //{ 
            //    int z = x + 1; 
            //    Console.WriteLine(z);
            //}

            //Overflow checking for constant expressions
            //int x = int.MaxValue + 1; // Compile-time error
            //int z = int.MaxValue;
            //z = z + 1; //No errors 
            //int y = unchecked(int.MaxValue + 1); // No errors

            //8 - and 16 - Bit Integral Types
            //short x = 1, y = 1;
            ////short z = x + y; // Compile-time error
            //short z = (short)(x + y); // OK

            //Special Float and Double Values
            //float and double follow the specification of the IEEE 754
            Console.WriteLine(1.0 / 0.0); // Infinity
            Console.WriteLine( -1.0 / 0.0); // -Infinity
            Console.WriteLine(1.0 / -0.0); // -Infinity
            Console.WriteLine( -1.0 / -0.0); // Infinity

            Console.WriteLine(0.0 / 0.0); // NaN
            Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0)); // NaN

            Console.WriteLine(0.0 / 0.0 == double.NaN); // False
            Console.WriteLine(double.IsNaN(0.0 / 0.0)); // True

        }
    }
}
