namespace Task3
{
    using System;

    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());

            int[,] matrix = new int[width, width];

            for (int i = 0; i < width; i++)
            {
                string line = Console.ReadLine();

                var inputParts = line.Split(' ');

                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = (byte)(line[j] - '0');           
                }
            }

            int count = 0;

            for (int i = 0; i < matrix.GetLength(0) - 4; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    // --------------Number 1 -----------------------
                    if (matrix[i + 2, j] == 1 && matrix[i + 1, j + 1] == 1 && matrix[i, j + 2] == 1 && matrix[i + 1, j + 2] == 1
                        && matrix[i + 2, j + 2] == 1 && matrix[i + 3, j + 2] == 1 && matrix[i + 4, j + 2] == 1)
                    {
                        count = count + 1;
                    }

                    // --------------Number 2-----------------------
                    if (matrix[i, j + 1] == 2 && matrix[i + 1, j] == 2 && matrix[i + 1, j + 2] == 2 && matrix[i + 2, j + 2] == 2
                        && matrix[i + 3, j + 1] == 2 && matrix[i + 4, j + 1] == 2 && matrix[i + 4, j] == 2 && matrix[i + 4, j + 2] == 2)
                    {
                        count = count + 2;
                    }

                    // --------------Number 3-----------------------
                    if (matrix[i, j] == 3 && matrix[i, j + 1] == 3 && matrix[i, j+ 2] == 3 && matrix[i + 1, j + 2] == 3 &&
                        matrix[i + 2, j + 2] == 3 && matrix[i + 2, j + 1] == 3 && matrix[i + 3, j + 2] == 3 && matrix[i + 4, j + 2] == 3 && matrix[i + 4, j + 1] == 3 && matrix[i + 4, j] == 3)
                    {
                        count = count + 3;
                    }

                    // --------------Number 4-----------------------
                    if (matrix[i, j] == 4 && matrix[i + 1, j] == 4 && matrix[i + 2, j] == 4 && matrix[i + 2, j + 1] == 4 && matrix[i + 2, j + 2] == 4 && matrix[i + 1, j + 2] == 4 && matrix[i, j + 2] == 4 && matrix[i + 3, j + 2] == 4 && matrix[i + 4, j + 2] == 4)
                    {
                        count = count + 4;
                    }

                    // --------------Number 5 -----------------------
                    if (matrix[i, j] == 5 && matrix[i, j + 1] == 5 && matrix[i, j + 2] == 5 && matrix[i + 1, j] == 5 && matrix[i + 2, j] == 5 && matrix[i + 2, j + 1] == 5 && matrix[i + 2, j + 2] == 5 && matrix[i + 3, j + 2] == 5 && matrix[i + 4, j + 2] == 5 && matrix[i + 4, j + 1] == 5 && matrix[i + 4, j] == 5)
                    {
                        count = count + 5;
                    }

                    // --------------Number 6 -----------------------
                    if (matrix[i, j] == 6 && matrix[i, j + 1] == 6 && matrix[i, j + 2] == 6 && matrix[i + 1, j] == 6 && matrix[i + 2, j] == 6 && matrix[i + 2, j + 1] == 6 && matrix[i + 2, j + 2] == 6 && matrix[i + 3, j] == 6 && matrix[i + 4, j] == 6 && matrix[i, j] == 6 && matrix[i + 4, j + 1] == 6 && matrix[i + 4, j + 2] == 6 && matrix[i+3, j+2] == 6)
                    {
                        count = count + 6;
                    }

                    // --------------Number 7-----------------------
                    if (matrix[i, j] == 7 && matrix[i, j + 1] == 7 && matrix[i, j + 2] == 7 && matrix[i + 1, j + 2] == 7 && matrix[i + 2, j + 1] == 7 && matrix[i + 3, j + 1] == 7 && matrix[i+4, j + 1] == 7)
                    {
                        count = count + 7;
                    }

                    // --------------Number 8-----------------------
                    if (matrix[i, j] == 8 && matrix[i, j + 1] == 8 && matrix[i, j + 2] == 8 && matrix[i + 1, j] == 8 && matrix[i + 1, j + 2] == 8 && matrix[i + 2, j + 1] == 8 && matrix[i + 3, j] == 8 && matrix[i + 4, j] == 8 && matrix[i + 3, j + 2] == 8 && matrix[i + 4, j + 2] == 8 && matrix[i+4, j+1] == 8)
                    {
                        count = count + 8;
                    }

                    // --------------Number 9-----------------------
                    if (matrix[i, j] == 9 && matrix[i, j + 1] == 9 && matrix[i, j + 2] == 9 && matrix[i + 1, j] == 9 && matrix[i + 1, j + 2] == 9 && matrix[i + 2, j + 1] == 9 && matrix[i + 2, j + 2] == 9 && matrix[i + 3, j + 2] == 9 && matrix[i + 4, j + 2] == 9 && matrix[i + 4, j + 1] == 9 && matrix[i+4, j] == 9)
                    {
                        count = count + 9;
                    }
                }    
            }

            Console.WriteLine(count);
        }

    }
}