using System;

namespace GotoStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 70
            //The goto statement transfers execution to another label within a statement block.
            int i = 1;
            startLoop:
            if (i <= 5)
            {
                Console.Write(i + " ");
                i++;
                goto startLoop;
            }
        }
    }
}
