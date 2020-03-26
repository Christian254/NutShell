using System;

namespace NullOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //PAge 60
            /* C# provides two operators to make it easier to work with nulls: the null coalescing
            operator and the null-conditional operator. */

            //Null Coalescing Operator ??
            string s1 = null;
            //if is null assigns nothing to S2"
            string s2 = s1 ?? "nothing"; // s2 evaluates to "nothing"
            Console.WriteLine(s2);


            //Page 61
            //Null conditional Operator ?.
            System.Text.StringBuilder sb = null;
            string s = sb?.ToString(); // No error; s instead evaluates to null
            Console.WriteLine(s);
            //The last line is equivalent to:
            //string s = (sb == null ? null : sb.ToString());

            System.Text.StringBuilder sb1 = null;
            string s3 = sb1?.ToString().ToUpper(); // s evaluates to null without error

            //The final expression must be capable of accepting a null. 
            //System.Text.StringBuilder sb = null;
            // int length = sb?.ToString().Length; // Illegal : int cannot be null
            //int? length = sb?.ToString().Length; // OK : int? can be null

            System.Text.StringBuilder sb2 = null;
            string s4 = sb2?.ToString() ?? "nothing"; // s evaluates to "nothing"
            Console.WriteLine($"s4: {s4}");
        }
    }
}
