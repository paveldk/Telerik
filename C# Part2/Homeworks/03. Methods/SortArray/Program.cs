// Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Lenght :");
        int length = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[length];
        Random random = new Random();

        Console.Write("Unsorted array: ");
        for (int i = 0; i < length; i++)
        {
            arrayOfNumbers[i] = random.Next(0, 100);
            Console.Write(arrayOfNumbers[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine("The maximal element in the array is {0}", arrayOfNumbers[MaximalElement(arrayOfNumbers, 0)]);

        Console.Write("Sorted array: ");
        ArraySort(arrayOfNumbers);
    }

    static int MaximalElement(int[] arrayOfNumbers, int startIndex)
    {
        int max = startIndex;
        for (int i = startIndex; i < arrayOfNumbers.Length; i++)
        {
            // Comparing each element in the array from start index to the end till I find biggest
            if (arrayOfNumbers[i] > arrayOfNumbers[max])
            {
                max = i;    
            }
        }

        return max;
    }

    static void ArraySort(int[] arrayOfNumbers)
    {
        for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
        {
            int max = MaximalElement(arrayOfNumbers, i); // I'm using the method to get the maximal element giving the array and the index of the loop is as StartIndex. This way each time I'll have sorted part to the left of the index and calling the method for the right part with help of the operations below:

            int temp = arrayOfNumbers[i];
            arrayOfNumbers[i] = arrayOfNumbers[max];
            arrayOfNumbers[max] = temp;
        }

        // The array is sorted from Max to Min, so for Ascending order I must print it from back to start:
        Console.WriteLine();
        Console.WriteLine("Ascending:");
        for (int i = arrayOfNumbers.Length - 1; i >= 0; i--)
        {
            Console.Write(arrayOfNumbers[i] + " ");    
        }

        // And normal way for descending:
        Console.WriteLine();
        Console.WriteLine("Descending:");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write(arrayOfNumbers[i] + " ");
        }

        Console.WriteLine();
    }
}