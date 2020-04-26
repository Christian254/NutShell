using System;

namespace BreakStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 70
            //The break statement ends the execution of the body of an iteration or switch statement
            int x = 0;
            while (true)
            {
                Console.WriteLine("iniciando el ciclo " + x);
                if (x++ > 5)
                {                    
                    break; // break from the loop
                }
                Console.WriteLine("terminando el ciclo" + x);
            }
        }
    }
}
