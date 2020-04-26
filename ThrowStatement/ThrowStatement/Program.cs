using System;

namespace ThrowStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 71 
            //The throw statement throws an exception to indicate an error has occurred
            string w = null;
            if (w == null)
                throw new ArgumentNullException();
        }
    }
}
