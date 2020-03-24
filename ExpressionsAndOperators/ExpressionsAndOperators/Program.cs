using System;

namespace ExpressionsAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 56
            //An expression essentially denotes a value
            //Expressions can be transformed and combined using operators.

            //Constant expression:
            const int number = 12;

            //We can use the * operator to combine two operands
            Console.WriteLine(number*30);

            //Complex escpressions
            Console.WriteLine(1 + (12 * 30));

            //Primary Expressions
            /*
             Primary expressions include expressions composed of operators that are intrinsic to
             the basic plumbing of the language.
            */

            /*
              This expression is composed of two primary expressions. The first expression per‐
              forms a member-lookup (with the . operator), and the second expression performs
              a method call (with the () operator).
              */
            Console.WriteLine(Math.Log(1));

            //Page 57

            //Void Expressions
            //A void expression, since it has no value,
            Console.WriteLine(1);

            //Assignment Expressions
            /*
             An assignment expression uses the = operator to assign the 
             result of another expression to a variable
            */
            int x = 2;
            x = x * 5;

            int y;
            y = 5 * (x = 2);
            Console.WriteLine(y);

            //compound assignment operators
            x *= 2; // equivalent to x = x * 2
            x <<= 1; // equivalent to x = x << 1

            //Page 58
            //Operator Precedence and Associativity
            // Left - associative operators
            /*Binary operators(except for assignment, lambda, and null coalescing operators) are
            left - associative; in other words, they are evaluated from left to right.
            */
            Console.WriteLine(8/4/2);

            //We can insert parentheses to change the actual order of evaluation
            Console.WriteLine(8 / (4 / 2));

            //Right-associative operators.
            //The assignment operators, lambda, null coalescing, and conditional operator are
            //right - associative; in other words, they are evaluated from right to left.
            x = y = 3;
        }
    }
}
