/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

 * */
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input the width of the matrix: ");
        int width = int.Parse(Console.ReadLine());

        int[,] arrayOfNumbers = new int[width, width];
        Random random = new Random();
        //We fill the matrix with Random numbers from 0 to 100
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                arrayOfNumbers[i, j] = random.Next(0,100);   
            }    
        }
        printArray(arrayOfNumbers,0,0, width, width);

        int sum = 0;
        int indexI = 0;
        int indexJ = 0;
        for (int i = 0; i < width-2; i++)
        {
            for (int j = 0; j < width-2; j++)
            {
                //check if the sum of current element + all element+2 around it(that's why the loops are to widht-2, not to get out of bounds) is bigger than sum(first time will be for sure) if so, sum get's it's sum and 2 index get's current i, j just to know which element to print later
                int currentsum =arrayOfNumbers[i,j]+arrayOfNumbers[i,j+1]+arrayOfNumbers[i,j+2]+arrayOfNumbers[i+1,j]+arrayOfNumbers[i+1,j+1]+arrayOfNumbers[i+1,j+2]+arrayOfNumbers[i+2,j]+arrayOfNumbers[i+2,j+1]+arrayOfNumbers[i+2,j+2]; 
                if (currentsum>sum)
                {
                    sum = currentsum;
                    indexI = i;
                    indexJ = j;
                }    
            }
            
        }

        Console.WriteLine(new String('-',Console.WindowWidth));
        Console.WriteLine("The biggest 3*3 submatrix(with sum {0}) in the matrix is:", sum);
        //and here we print the elements
        printArray(arrayOfNumbers, indexI, indexJ, indexI + 3, indexJ+3);

    }

    //Method for print of the matrix with start and elements, becouse in the second print we need just part of the matrix
    private static void printArray(int[,] matrix, int iStart, int jStart, int iEnd, int jEnd)
    {
        for (int i = iStart; i < iEnd; i++)
        {
            for (int j = jStart; j < jEnd; j++)
            {
                Console.Write("{0,6}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

