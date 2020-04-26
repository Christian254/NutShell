using System;

namespace ContinueStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 70
            //The continue statement forgoes the remaining statements in a loop and makes an
            //early start on the next iteration. The following loop skips even numbers:
            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) == 0) // If i is even,
                    continue; // continue with next iteration
                Console.Write(i + " ");
            }
        }
    }
}
