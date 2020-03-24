using System;

namespace DefiniteAssignment
{
    class Program
    {
        static int x;
        static void Main(string[] args)
        {
            //Page 47 - 48
            Console.WriteLine("Hello World!");
            /*
             Definite assignment has three implications:
             - Local variables must be assigned a value before they can be read
             - Function arguments must be supplied when a method is called 
             (unless marked as optional)
             - All other variables (such as fields and array elements) are 
             automatically initialized by the runtime.
             Example:
             static void Main()
             {
                int x;
                Console.WriteLine (x); // Compile-time error
             }

             */
            //Fields and array elements are automatically initialized with the default values for
            //their type.
            int[] ints = new int[2];
            Console.WriteLine(ints[0]); // 0
            Console.WriteLine(x); //0

        }
    }
}
