using System;

namespace BooleanTypeAndOperators
{
    class Program
    {
        //Page 37 - 38 - 39
        public class Dude
        {
            public string Name;
            public Dude(string n) { Name = n; }
        }
        static void Main(string[] args)
        {

            //Equality and Comparison Operators
            int x = 1;
            int y = 2;
            int z = 1;
            Console.WriteLine(x == y); // False

            Console.WriteLine(x == z); // True

            //For references types 
            Dude d1 = new Dude("John");
            Dude d2 = new Dude("John");
            Console.WriteLine(d1 == d2); // False
            Dude d3 = d1;
            Console.WriteLine(d1 == d3); // True

            //Conditional operators
            bool useUmbrella = UseUmbrella(true, false, false);

            //Ternary Operator
            Console.WriteLine(useUmbrella ? "Yes, you should use umbrella": "No");
        }
        static bool UseUmbrella(bool rainy, bool sunny, bool windy)
        {
            return !windy && (rainy || sunny);
        }
    }
}
