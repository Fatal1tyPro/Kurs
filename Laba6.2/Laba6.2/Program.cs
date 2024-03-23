using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5._2
{

    class Program
    {
        static void Main()
        {
            int[,] matrix1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            int[,] matrix2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

            int[,] resultMatrix = AddMatrices(matrix1, matrix2);

            PrintMatrix(resultMatrix);
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1 == null || matrix2 == null ||
                matrix1.GetLength(0) != matrix2.GetLength(0) ||
                matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                Console.WriteLine("Invalid parameters.");
                return null;
            }

            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);

            int[,] resultMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return resultMatrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            if (matrix == null)
                return;

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
