/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

 * */
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input the width of the matrix: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Please input the height of the matrix: ");
        int height = int.Parse(Console.ReadLine());

        string[,] arrayOfStrings = new string[height,width];
        
        //Fill the matrix
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("Please enter value for arr[{0},{1}]: ", i, j);
                arrayOfStrings[i, j] = Console.ReadLine();
            }    
        }

        printArray(arrayOfStrings);

        string longest = "";
        int currentCount = 1;
        int count = 1;

        //check for the rows
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width-1; j++)
            {
                if (arrayOfStrings[i, j] == arrayOfStrings[i, j+1])
                {
                    currentCount++;    
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > count)
                {
                    longest = arrayOfStrings[i, j];
                    count = currentCount;
                }
            }
            currentCount = 1;

        }

        //Check for the columns
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height - 1; j++)
            {
                if (arrayOfStrings[j,i] == arrayOfStrings[j+1,i])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > count)
                {
                    longest = arrayOfStrings[j, i];
                    count = currentCount;
                }
            }
            currentCount = 1;

        }
        
        //Main diagonals
        for (int i = 0; i < height-1; i++)
        {
            for (int j = 0; j < width-1; j++)
            {
                for (int rows = i, cols = j; rows < height - 1 && cols < width - 1; rows++, cols++)
                {
                    if (arrayOfStrings[rows, cols] == arrayOfStrings[rows + 1, cols + 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }

                    if (currentCount > count)
                    {
                        longest = arrayOfStrings[rows, cols];
                        count = currentCount;
                    }
                }
                currentCount = 1;
            }

        }

       //And secondary
        for (int i = 0; i < height - 1; i++)
        {
            for (int j = 1; j < width; j++)
            {
                for (int rows = i, cols = j; rows < height - 1 && cols > 0; rows++, cols--)
                {
                    if (arrayOfStrings[rows, cols] == arrayOfStrings[rows + 1, cols - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }

                    if (currentCount > count)
                    {
                        longest = arrayOfStrings[rows, cols];
                        count = currentCount;
                    }
                }
                currentCount = 1;
            }

        }

        //Print the longest line
        Console.Write("The longest line: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(longest + " ");    
        }
        Console.WriteLine();
    }

    //Method for print of the matrix
    private static void printArray(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,6}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
