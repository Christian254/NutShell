using System;
using Outer.Middle.Inner;
using System.Security.Cryptography;
namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //page 71 - 72
            /*A namespace is a domain for type names. Types are typically organized into hierarchical namespaces, 
             * making them easier to find and avoiding conflicts*/
            /* The using directive imports a namespace, allowing you to refer to types without
            their fully qualified names */
            var rsa = RSA.Create();
            Class1 c;
        }
    }   
}
namespace Outer.Middle.Inner
{
    class Class1 { }
    class Class2 { }
}
