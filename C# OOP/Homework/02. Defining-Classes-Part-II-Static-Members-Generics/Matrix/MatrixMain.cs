// The task condition is in the file TaskCondition.docx
namespace Matrix
{
    using System;
    using System.Collections.Generic;

    class MatrixMain
    {
        static void Main()
        {
            Matrix<int> matrix1 = new Matrix<int>();

            matrix1[0, 0] = 2;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 2;
            matrix1[1, 1] = 2;

            Matrix<int> matrix2 = new Matrix<int>();

            matrix2[0, 0] = 3;
            matrix2[0, 1] = 3;
            matrix2[1, 0] = 3;
            matrix2[1, 1] = 3;

            Matrix<int> matrix3 = new Matrix<int>();

            matrix3 = matrix1 + matrix2;

            Console.WriteLine("Addition:");
            matrix3 = matrix1 + matrix2;
            PrintMatrix(matrix3);

            Console.WriteLine("Substraction:");
            matrix3 = matrix1 - matrix2;
            PrintMatrix(matrix3);

            Console.WriteLine("Multiplication:");
            matrix3 = matrix1 * matrix2;
            PrintMatrix(matrix3);
        }

        private static void PrintMatrix(Matrix<int> matrix)
        {
            for (int row = 0; row < matrix.Row; row++)
            {
                for (int col = 0; col < matrix.Col; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
