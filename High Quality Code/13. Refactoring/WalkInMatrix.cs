namespace Matrix
{
    using System;

    internal class WalkInMatrix
    {
        static int row = 0;
        static int column = 0;
        static int number = 1;
        static int currentDirectionX = 1;
        static int currentDirectionY = 1;
        static int[,] matrix;

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int length = 0;
            while (!int.TryParse(input, out length) || length < 0 || length > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            matrix = new int[length, length];
                
            CheckForValidDirection(matrix);

            PrintMatrix(matrix);

            if (FirstFreeCellFound(matrix))
            {               
                CheckForValidDirection(matrix);
            }

            PrintMatrix(matrix);
        }

        private static void Change(ref int dx, ref int dy)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int cd = 0;
            for (int count = 0; count < 8; count++)
            {
                if (directionX[count] == dx && directionY[count] == dy)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                dx = directionX[0];
                dy = directionY[0];
                return;
            }

            dx = directionX[cd + 1];
            dy = directionY[cd + 1];
        }

        private static bool CheckValidDirections(int[,] arr, int x, int y)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + directionX[i] >= arr.GetLength(0) || x + directionX[i] < 0)
                {
                    directionX[i] = 0;
                }

                if (y + directionY[i] >= arr.GetLength(0) || y + directionY[i] < 0)
                {
                    directionY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + directionX[i], y + directionY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool FirstFreeCellFound(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static void CheckForValidDirection(int[,] arr)
        {
            currentDirectionX = 1;
            currentDirectionY = 1;

            bool isDirectionValid = true;

            while (isDirectionValid)
            {
                arr[row, column] = number;

                isDirectionValid = CheckValidDirections(arr, row, column);

                if (isDirectionValid)
                {
                    if (row + currentDirectionX >= arr.GetLength(0) || row + currentDirectionX < 0 || column + currentDirectionY >= arr.GetLength(1) || column + currentDirectionY < 0 || arr[row + currentDirectionX, column + currentDirectionY] != 0)
                    {
                        while (row + currentDirectionX >= arr.GetLength(0) || row + currentDirectionX < 0 || column + currentDirectionY >= arr.GetLength(1) || column + currentDirectionY < 0 || arr[row + currentDirectionX, column + currentDirectionY] != 0)
                        {
                            Change(ref currentDirectionX, ref currentDirectionY);
                        }
                    }

                    row += currentDirectionX;
                    column += currentDirectionY;
                    number++;
                }
            }
        }

        private static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,3}", arr[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}