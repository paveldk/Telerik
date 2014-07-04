/*You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Please input the width of the matrix: ");
        int width = int.Parse(Console.ReadLine());

        string[] arrayOfStrings = new string[width];

        //Fill the matrix
        for (int i = 0; i < width; i++)
        {
             Console.Write("Please enter value for arr[{0}]: ", i);
             arrayOfStrings[i] = Console.ReadLine();
        }

        Console.WriteLine("Unsorted array:");
        printArray(arrayOfStrings);
        Console.WriteLine(new String('-',Console.WindowWidth));

        Console.WriteLine("Sorted array:");
        //using Linq OrderBy
        foreach (var item in arrayOfStrings.OrderBy(elements => elements.Length))
        {
            Console.WriteLine(item);
        }

    }
    private static void printArray(string[] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine("{0,6}", matrix[i]);
        }
    }

}


