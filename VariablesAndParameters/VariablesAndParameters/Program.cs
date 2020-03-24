using System;
using System.Text;
namespace VariablesAndParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 46
            //The stack is a block of memory for storing local variables and parameters
            Console.WriteLine(Factorial(5));

            //The heap is a block of memory in which objects (i.e., reference-type instances)
            //reside.
            StringBuilder ref1 = new StringBuilder("object1");
            Console.WriteLine(ref1);
            // The StringBuilder referenced by ref1 is now eligible for GC.
            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 = ref2;
            // The StringBuilder referenced by ref2 is NOT yet eligible for GC.
            Console.WriteLine(ref3); // object2

        }

        //Method is recursive
        static int Factorial(int x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }
    }
}
