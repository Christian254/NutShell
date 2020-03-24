using System;

namespace ImplicitlyTypedLocalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 55 - 56
            var x = "hello";
            var y = new System.Text.StringBuilder();
            var z = (float)Math.PI;
            /*
             * This is equivalent to:
             * string x = "hello";
             * System.Text.StringBuilder y = new System.Text.StringBuilder();
             * float z = (float)Math.PI;
             */
            /*
             * var can decrease code readability in the case when you can’t
             * deduce the type purely by looking at the variable declaration
             */
        }
    }
}
