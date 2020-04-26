using System;

namespace ReturnStatement
{
    class Program
    {
        //Page 71
        //The return statement exits the method and must return an expression of the
        //method’s return type if the method is nonvoid:
        static void Main(string[] args)
        {
            decimal porcentage = AsPercentage(0.25m);
            Console.WriteLine(porcentage);
        }
        static decimal AsPercentage(decimal d)
        {
            decimal p = d * 100m;
            return p; // Return to the calling method with value
        }
    }
}
