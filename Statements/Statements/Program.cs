using System;
using System.Text;


namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 62
            //Declaration Statements
            //Declaring multiple variables of the same type in a comma-separated list
            string someWord = "rosebud";
            int someNumber = 42;
            bool rich = true, famous = false;

            //Constant declaration is like a variable declaration, except that it cannot
            //be changed after it has been declared;
            const double c = 2.99792458E08;
            //c += 10; // Compile-time Error

            //Loxal variables
            //int x;
            //{
            //    int y;
            //    //int x; // Error - x already defined
            //}
            //{
            //    int y; // OK - y not in scope
            //    Console.WriteLine(y = 10);
            //}
            //Console.Write(y); // Error - y is out of scope

            //Page 63
            //Expression Statements
            // Declare variables with declaration statements:
            string s;
            int x, y;
            StringBuilder sb;
            // Expression statements
            x = 1 + 2; // Assignment expression
            x++; // Increment expression
            Console.WriteLine(x);
            y = Math.Max(x, 5); // Assignment expression
            Console.WriteLine(y); // Method call expression
            sb = new StringBuilder(); // Assignment expression
            new StringBuilder(); // Object instantiation expression
            new StringBuilder(); // Legal, but useless
            new string('c', 3); // Legal, but useless
            Console.WriteLine(x.Equals(y)); // Legal, but useless
        }
    }
}
