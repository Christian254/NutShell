using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pages 43 - 44
            //Rectangular Arrays
            int[,] matrix = new int[3, 3];
            Console.WriteLine("\t****************");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * 3 + j;
                    Console.Write("\t" + matrix[i, j]);
                }
                Console.WriteLine("\n");
            }
            /*A rectangular array can be initialized as follows (to create an array identical to the
            previous example):*/
            int[,] matrix1 = new int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            Console.WriteLine("\t****************");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write("\t" + matrix[i, j]);
                }
                Console.WriteLine("\n");
            }

        }
    }
}
