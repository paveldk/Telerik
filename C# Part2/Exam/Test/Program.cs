namespace _03_Digits
{
    using System;
    class Digits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine().Replace(" ", "");


                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = (byte)(line[col] - '0');
                }
            }

            int result = 0;
            for (int row = 0; row < n - 4; row++)
            {
                for (int col = 0; col < n - 2; col++)
                {
                    if (matrix[row + 2, col] == 1 && matrix[row + 1, col + 1] == 1 &&
                        matrix[row, col + 2] == 1 && matrix[row + 1, col + 2] == 1 &&
                        matrix[row + 2, col + 2] == 1 &&
                        matrix[row + 3, col + 2] == 1 && matrix[row + 4, col + 2] == 1)
                    {
                        result++;
                    }

                    if (matrix[row + 1, col] == 2 && matrix[row + 4, col] == 2 &&
                        matrix[row, col + 1] == 2 && matrix[row + 3, col + 1] == 2 &&
                        matrix[row + 4, col + 1] == 2 && matrix[row + 1, col + 2] == 2 &&
                        matrix[row + 2, col + 2] == 2 && matrix[row + 4, col + 2] == 2)
                    {
                        result += 2;
                    }
                    if (matrix[row, col] == 3 && matrix[row, col + 1] == 3 &&
                        matrix[row, col + 2] == 3 && matrix[row + 1, col + 2] == 3 &&
                        matrix[row + 2, col + 1] == 3 && matrix[row + 2, col + 2] == 3 &&
                        matrix[row + 3, col + 2] == 3 && matrix[row + 4, col] == 3 &&
                        matrix[row + 4, col + 1] == 3 && matrix[row + 4, col + 2] == 3)
                    {
                        result += 3;
                    }
                    if (matrix[row, col] == 4 && matrix[row, col + 2] == 4 &&
                        matrix[row + 1, col] == 4 && matrix[row + 1, col + 2] == 4 &&
                        matrix[row + 2, col] == 4 && matrix[row + 2, col + 1] == 4 &&
                        matrix[row + 2, col + 2] == 4 && matrix[row + 3, col + 2] == 4 &&
                        matrix[row + 4, col + 2] == 4)
                    {
                        result += 4;
                    }
                    if (matrix[row, col] == 5 && matrix[row, col + 1] == 5 &&
                        matrix[row, col + 2] == 5 && matrix[row + 1, col] == 5 &&
                        matrix[row + 2, col] == 5 && matrix[row + 2, col + 1] == 5 &&
                        matrix[row + 2, col + 2] == 5 && matrix[row + 3, col + 2] == 5 &&
                        matrix[row + 4, col] == 5 && matrix[row + 4, col + 1] == 5 &&
                        matrix[row + 4, col + 2] == 5)
                    {
                        result += 5;
                    }
                    if (matrix[row, col] == 6 && matrix[row, col + 1] == 6 &&
                        matrix[row, col + 2] == 6 && matrix[row + 1, col] == 6 &&
                        matrix[row + 2, col] == 6 && matrix[row + 2, col + 1] == 6 &&
                        matrix[row + 2, col + 2] == 6 && matrix[row + 3, col] == 6 &&
                        matrix[row + 3, col + 2] == 6 &&
                        matrix[row + 4, col] == 6 && matrix[row + 4, col + 1] == 6 &&
                        matrix[row + 4, col + 2] == 6)
                    {
                        result += 6;
                    }
                    if (matrix[row, col] == 7 && matrix[row, col + 1] == 7 &&
                        matrix[row, col + 2] == 7 && matrix[row + 1, col + 2] == 7 &&
                        matrix[row + 2, col + 1] == 7 &&
                        matrix[row + 3, col + 1] == 7 &&
                        matrix[row + 4, col + 1] == 7)
                    {
                        result += 7;
                    }
                    if (matrix[row, col] == 8 && matrix[row, col + 1] == 8 &&
                        matrix[row, col + 2] == 8 && matrix[row + 1, col] == 8 &&
                        matrix[row + 1, col + 2] == 8 && matrix[row + 2, col + 1] == 8 &&
                        matrix[row + 3, col] == 8 && matrix[row + 3, col + 2] == 8 &&
                        matrix[row + 4, col] == 8 && matrix[row + 4, col + 1] == 8 &&
                        matrix[row + 4, col + 2] == 8)
                    {
                        result += 8;
                    }
                    if (matrix[row, col] == 9 && matrix[row, col + 1] == 9 &&
                        matrix[row, col + 2] == 9 && matrix[row + 1, col] == 9 &&
                        matrix[row + 1, col + 2] == 9 && matrix[row + 2, col + 1] == 9 &&
                        matrix[row + 2, col + 2] == 9 && matrix[row + 3, col + 2] == 9 &&
                        matrix[row + 4, col] == 9 && matrix[row + 4, col + 1] == 9 &&
                        matrix[row + 4, col + 2] == 9)
                    {
                        result += 9;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}