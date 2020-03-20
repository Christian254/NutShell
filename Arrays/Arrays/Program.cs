using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pages 42 - 43  
            /*A array are always stored in a contiguous block of memory providing
            highly efficient access.
             */

            char[] vowels = new char[5];
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';
            Console.WriteLine(vowels[1]);

            //Array indexes start at 0
            Console.WriteLine("****For Loop****");
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }

            //Differents forms to initialize an array
            char[] vowels1 = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] vowels2 = { 'a', 'e', 'i', 'o', 'u' };

            //Arrays Length 
            Console.WriteLine("Arrays Length");
            Console.WriteLine($"Vowels1 length {vowels1.Length}");
            Console.WriteLine($"Vowels2 length {vowels2.Length}");


            //Default Element Initialization
            Console.WriteLine("****Default Initialization****");
            int[] a = new int[1000];
            Console.WriteLine(a[123]);

            //Value Types vrs reference types
            Console.WriteLine("Value Types vrs reference types");
            Console.WriteLine("Struct Point");
            Point[] point = new Point[1000];
            int x = point[500].X;
            Console.WriteLine(x);
            Console.WriteLine("Point Class");
            //Runtime error, NullReferenceException because each object must be instantiated
            //PointClass[] points = new PointClass[1000];
            //int x1 = points[500].X;
            //Console.WriteLine(x1);

            //instantiate 1,000 Points after instantiating the array:
            PointClass[] points = new PointClass[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new PointClass();
            }
            int x1 = points[500].X;
            Console.WriteLine(x1);

        }
        public struct Point { public int X, Y; }
        public class PointClass { public int X, Y; }
    }
}
