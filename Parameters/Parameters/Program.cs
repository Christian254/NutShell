using System;
using System.Text;

namespace Parameters
{
    class Program
    {
        static int xImplication;
        static void Main(string[] args)
        {
            //Page 49
            Foo(8); // Print 9
            //Passing arguments by value
            int x = 8;
            Foo(x); // Make a copy of x
            Console.WriteLine(x); //Print 8

            //Parameters by reference
            StringBuilder sb = new StringBuilder();
            FooString(sb);
            /*
            setting it to null doesn’t make sb null. (If,
            however, fooSB was declared and called with the ref modifier,
            sb would become null.)
            */
            Console.WriteLine(sb.ToString());

            //Page 50 - 51
            //The ref modifier
            //To pass by reference, C# provides the ref parameter modifier.
            Console.WriteLine("\n*****Ref Modifier*****");
            int xRef = 8;
            FooRef(ref xRef); // Ask Foo to deal directly with x
            Console.WriteLine($"xRef {xRef}"); // x is now 9

            //Swap Test 
            Console.WriteLine("\n*****Swap Test*****");
            string firstName = "Christian";
            string lastName = "Fuentes";
            Swap(ref firstName, ref lastName);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);


            //The out modifier
            Console.WriteLine("\n*****Out Modifier*****");
            string a, b;
            Split("Christian Alexis Fuentes", out a, out b);
            Console.WriteLine(a); 
            Console.WriteLine(b);

            //Page 52
            //Out variables and discards 
            Console.WriteLine("\n*****Out variables and discards*****");
            Split("Stevie Ray Vaughan", out string c, out _); // Discard the 2nd param
            Console.WriteLine(c);
            Console.WriteLine("\n**** Implications of passing by reference ****");
            FooImplications(out xImplication);

            //Page 53
            //The params modifier
            Console.WriteLine("\n****The params modifier****");
            int total = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(total);

            //Optional params
            Console.WriteLine("\n****Optional parameters****");
            FooOptional();
            FooOptional(50);

            FooOptional2(1);
            FooOptional2(0, 5);

            //Page 54 - 55
            //Named arguments
            Console.WriteLine("\n****Named arguments****");
            //we give the value to the variable name
            FooNamedArguments(y: 40, x: 20);
            FooNamedArguments(1, y: 2);
            FooNamedArguments(x:1, 2);
            Bar(a: 10, c: 20);
            Bar(c: 15, b: 40);
        }



        /* METHODS */
        static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }
        static void FooString(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
            Console.WriteLine(fooSB); //null
        }
        static void FooRef(ref int p)
        {
            p = p + 1; // Increment p by 1
            Console.WriteLine($"FooRef - p: {p}"); // Write p to screen
        }
        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static void Split(string name, out string firstNames, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }

        static void FooImplications(out int y)
        {
            Console.WriteLine(xImplication); // x is 0
            y = 1; // Mutate y
            Console.WriteLine(xImplication); // x is 1
        }

        static int Sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }

        static void FooOptional(int x = 23)
        {
            Console.WriteLine(x);
        }

        static void FooOptional2(int x = 0, int y = 0)
        {
            Console.WriteLine(x + ", " + y);
        }

        static void FooNamedArguments(int x, int y)
        {
            Console.WriteLine(x + ", " + y);
        }
        static void Bar (int a = 0, int b = 0, int c = 0)
        {
            Console.WriteLine($"a:{a} b:{b} c:{c}");
        }
    }
}
