using System;
using static System.Console;
namespace UsingDirective
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 73
            //using static
            //From C# 6, you can import not just a namespace, but a specific type, with the using
            //static directive.All static members of that type can then be used without being
            //qualified with the type name
            WriteLine("testing using static");
            //Rules Within a Namespace

        }
    }
}
//Name hiding
namespace Outer
{
    class Foo { }
    namespace Inner
    {
        class Foo { }
        class Test
        {
            Foo f1; // = Outer.Inner.Foo
            Outer.Foo f2; // = Outer.Foo
        }
    }
}
