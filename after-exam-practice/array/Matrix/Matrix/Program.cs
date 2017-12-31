using System;
using System.Collections.Generic;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            /*{
                {1, 0, 0, 0 },
                {0, 1, 0, 0 },
                {0, 0, 1, 0 },
                {0, 0, 0, 1 }
            };*/
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((i * 4 + j) % 5 == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
