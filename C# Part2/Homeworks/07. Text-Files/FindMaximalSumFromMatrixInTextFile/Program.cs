/*Write a program that reads a text file containing a square matrix of numbers and finds 
 * in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
 * The first line in the input file contains the size of matrix N. 
 * Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4     17
3 7 1 2
4 3 3 2
*/
namespace FindMaximalSumFromMatrixInTextFile
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            ReadMatrix();
        }

        private static void ReadMatrix()
        {
            // Method for reading the Matrix from file
            string fileName = @"..\..\Test.txt";
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                int length = int.Parse(reader.ReadLine());
                int[,] matrix = new int[length, length];

                for (int i = 0; i < length; i++)
                {
                    // We're using Split method with giving space as atribute
                    string[] numbers = reader.ReadLine().Split(' ');
                    for (int j = 0; j < length; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[j]);
                    }                       
                }

                // Then we call our second method for find the best sum
                FindBestSum(matrix);
            }            
        }

        private static void FindBestSum(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    // where we check if the sum of current element + all element+1 around it(that's why the loops are to widht-1, not to get out of bounds) is bigger than sum(first time will be for sure) if so, sum get's it's sum 
                    int currentsum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (currentsum > sum)
                    {
                        sum = currentsum;
                    }
                }
            }

            // finally we write to other file only best sum
            string fileName = @"..\..\BestSum.txt";
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.WriteLine("{0}", sum);    
            }
        }
    }
}
