/*Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Lenght :");
        int length = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            arrayOfNumbers[i] = random.Next(0, 10); // I set the random from 0 to 10 so to be more probably same numbers to appear
            Console.WriteLine(arrayOfNumbers[i] + " ");
        }

        Console.Write("Number :");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} appears {1} times in the array", number, CountNumbers(arrayOfNumbers, number));
    }

    static int CountNumbers(int[] arrayOfNumbers, int searchNumber)
    {
        int count = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] == searchNumber)
            {
                // if the number from the array is our searched one count++. After we exit the loop we return the count.
                count++;    
            }  
        }

        return count;
    }
}
