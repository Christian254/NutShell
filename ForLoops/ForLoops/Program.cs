using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 69
            /*
             for loops are like while loops with special clauses for initialization and iteration of
            a loop variable. A for loop contains three clauses as follows:
            for (initialization-clause; condition-clause; iteration-clause)
            statement-or-statement-block
             */
            for (int i = 0, prevFib = 1, curFib = 1; i < 10; i++)
            {
                Console.WriteLine(prevFib);
                int newFib = prevFib + curFib;
                prevFib = curFib; 
                curFib = newFib;
            }
            /*foreach loops
            The foreach statement iterates over each element in an enumerable object. Most of
            the types in C# and the .NET Framework that represent a set or list of elements are
            enumerable.*/
            foreach (char c in "beer") // c is the iteration variable
                Console.WriteLine(c);
        }
    }
}
