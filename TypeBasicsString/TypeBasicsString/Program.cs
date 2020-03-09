using System;

namespace TypeBasicsString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Christian Fuentes
            //Type Basics, Strings. Page 21
            string message = "Hello world";
            string upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage);

            int x = 2015;
            message = message + x.ToString();
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
