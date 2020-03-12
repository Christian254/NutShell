using System;

namespace ReferenceTypes
{
    class Program
    {
        public struct Point
        {
            public int X;
            public int Y;
        }
        //public class Point
        //{
        //    public int X;
        //    public int Y;
        //}
        static void Main(string[] args)
        {
            //Christian Fuentes
            //Reference Types Example. Page 26


            //Point p1 = new Point();
            //p1.X = 7;
            //Point p2 = p1; // Copies p1 reference
            //Console.WriteLine(p1.X); // 7
            //Console.WriteLine(p2.X); // 7
            //p1.X = 9; // Change p1.X
            //Console.WriteLine(p1.X); // 9
            //Console.WriteLine(p2.X); // 9
            //Point p = null;
            //Console.WriteLine(p == null); // True
            //// The following line generates a runtime error
            //// (a NullReferenceException is thrown):
            //Console.WriteLine(p.X);

            //Compile-time error
            Point p = null;
            int x = null;
        }
    }
}
