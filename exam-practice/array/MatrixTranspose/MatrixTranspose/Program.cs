using System;
using System.Text;

namespace MatrixTranspose
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
           {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9},
           };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void Transpose(int[,] matrix)
        {
            int[,] transposedMatrix = matrix;

            for (int i = 0; i < transposedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < transposedMatrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        //return transposeMatrix.ToString();
        }     
    }
}