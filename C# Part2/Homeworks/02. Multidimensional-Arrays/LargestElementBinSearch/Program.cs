/*Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input the length of the array: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Please input the number K: ");
        int K = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[width];

        Random random = new Random();
        //We fill the matrix with Random numbers from 0 to 100
        for (int i = 0; i < width; i++)
        {
            arrayOfNumbers[i] = random.Next(0, 100);
        }

        Console.WriteLine("Unsorted array:");
        printArray(arrayOfNumbers);
        Console.Write(new String('-', Console.WindowWidth));

        Array.Sort(arrayOfNumbers);
        Console.WriteLine("Sorted array:");
        printArray(arrayOfNumbers);

        int result = 0;

        if (arrayOfNumbers[0] <= K)
        {
            int index = Array.BinarySearch(arrayOfNumbers, K); //we get the index of the element=K
            if (index >= 0)
            {
                //if the index is>= so there is K in the array - we get and later print it
                result = arrayOfNumbers[index];
            }
            else
            {
                //but if not we binary reverse the index and get previous index, that's largest element in array <=K 
               // result = arrayOfNumbers[~index - 1];
                int temp = -index;
                result = arrayOfNumbers[temp - 2];
            }                    
        }
        else
        {
            Console.WriteLine("There is no number that is less than or equal to k.");
        }

        Console.WriteLine();
        Console.WriteLine("The largest element in array <={0} is {1}.", K,result); 
         
        
    }
    //Method for print of the matrix
    private static void printArray(int[] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           Console.Write("{0,6}", matrix[i]);
        }
        Console.WriteLine();
    }
}

