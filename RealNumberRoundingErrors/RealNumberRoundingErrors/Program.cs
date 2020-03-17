using System;

namespace RealNumberRoundingErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 37   
            float tenth = 0.1f; // Not quite 0.1
            float one = 1f;
            Console.WriteLine(one - tenth * 10f); // -1.490116E-08

            decimal m = 1M / 6M; // 0.1666666666666666666666666667M
            double d = 1.0 / 6.0; // 0.16666666666666666

            decimal notQuiteWholeM = m + m + m + m + m + m; // 1.0000000000000000000000000002M
            double notQuiteWholeD = d + d + d + d + d + d; // 0.99999999999999989

            Console.WriteLine(notQuiteWholeM);
            Console.WriteLine(notQuiteWholeM == 1M); // False
            Console.WriteLine(notQuiteWholeD);
            Console.WriteLine(notQuiteWholeD < 1.0); // True

        }
    }
}
