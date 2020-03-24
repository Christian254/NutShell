using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 2;
            //Page 44 - 45 - 46
            int[][] matrix = new int[3][];
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    matrix[i] = new int[length]; // Create inner array
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        matrix[i][j] = i * 3 + j;
            //        Console.Write("\t" + matrix[i][j]);
            //    }
            //    Console.WriteLine();
            //    length++;
            //}

            //A jagged array can be initialized as follows
            int[][] matrix1 = new int[][]
             {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8,9}
             };
            Console.WriteLine("**************************");
            for (int i = 0; i < matrix1.Length; i++)
            {
                for (int j = 0; j < matrix1[i].Length; j++)
                {
                    Console.Write("\t" + matrix1[i][j]);
                }
                Console.WriteLine();
            }
            //Simplified Array Initialization
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[,] rectangularMatrix =
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            int[][] jaggedMatrix =
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8}
            };
            var iTest = 3; // iTest is implicitly of type int
            var s = "sausage"; // s is implicitly of type string
            // Therefore:
            var rectMatrix = new int[,] // rectMatrix is implicitly of type int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            var jaggedMat = new int[][] // jaggedMat is implicitly of type int[][]
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8}
            };
            var vowelsTest = new[] { 'a', 'e', 'i', 'o', 'u' }; // Compiler infers char[]
            
        }
    }
}
