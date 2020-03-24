using System;

namespace RefLocalsAndReturns
{
    class Program
    {
        static string x = "Old Value";
        static void Main(string[] args)
        {
            //Page 55
            //Ref Locals 
            /* 
              you can define a local variable that references
              an element in an array or field in an object:
             */
            Console.WriteLine("****Ref Locals****");
            int[] numbers = { 0, 1, 2, 3, 4 };
            ref int numRef = ref numbers[2];
            /* 
             numRef is a reference to the numbers[2]. When we modify numRef,
             we modify the array element
             */

            //The target for a ref local must be an array element, field, or local variable
            numRef *= 10;
            Console.WriteLine(numRef); // 20
            Console.WriteLine(numbers[2]); // 20

            //We can return a ref local from a method. This is called a ref return
            Console.WriteLine("****Ref Returns*****");
            ref string xRef = ref GetX();
            xRef = "New Value";
            Console.WriteLine(x);
        }
        static ref string GetX()
        {
            Console.WriteLine(x);
            return ref x;
        }
    }
}
