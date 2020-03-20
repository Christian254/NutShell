using System;

namespace StringsType
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Type
            //Pages 40 - 41 - 42
            //represents an immutable sequence of Unicode characters. A string literal is speci‐
            //fied inside double quotes:
            //string a = "Heat";

            //string is a reference type, rather than a value type.
            //Its equality operators, however, follow value - type semantics
            string a = "test";
            string b = "test";
            Console.WriteLine(a == b);

            //The escape sequences also work inside strings
            string c = "Here's a tab:\ttab";
            Console.WriteLine(c);

            //to write a forward slash I have to do it twice
            string a1 = "\\\\server\\fileshare\\helloworld.cs";
            Console.WriteLine(a1);

            //To avoid this problem, C# allows verbatim string literals
            //Example: 
            string a2 = @"\\server\fileshare\helloworld.cs";
            Console.WriteLine(a2);

            //A verbatim string literal can also span multiple lines:
            string escaped = "First Line\r\nSecond Line";
            string verbatim = @"First Line
Second Line";
            Console.WriteLine(escaped);
            Console.WriteLine(verbatim);

            // True if your IDE uses CR-LF line separators:
            Console.WriteLine(escaped == verbatim);

            //can include the double-quote character in a verbatim literal by writing it twice
            string xml = @"<customer id=""123""></customer>";
            Console.WriteLine(xml);


            //String concatenation
            string s = "a" + "b";
            Console.WriteLine(s);
            string s1 = "a" + 5; // a5
            Console.WriteLine(s1);

            //String interpolation
            //$ is used to interpolate
            int x = 4;
            Console.Write($"A square has {x} sides \n"); // Prints: A square has 4 sides          

            string s2 = $"255 in hex is {byte.MaxValue:X2}"; // X2 = 2-digit Hexadecimal
            // Evaluates to "255 in hex is FF

            //Interpolated strings must complete on a single line, 
            //unless you also specify the verbatim string operator. Note that the $ operator must come before @:
            Console.WriteLine(s2);
            int x3 = 2;
            string s3 = $@"this spans {
            x3} lines";
            Console.WriteLine(s3);

            //String comparisons
            //string does not support<and> operators for comparisons
        }
    }
}
