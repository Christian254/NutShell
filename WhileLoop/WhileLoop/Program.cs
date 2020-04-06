using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while loops repeatedly execute a body of code while a bool expression is true.The
            expression is tested before the body of the loop is executed */
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 0;
            //the do-while loop ensures that the loop runs at least once
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 3);
        }
    }
}
