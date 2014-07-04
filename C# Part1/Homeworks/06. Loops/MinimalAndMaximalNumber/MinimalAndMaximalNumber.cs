using System;
using System.Linq;

class MinimalAndMaximalNumber
{
    static void Main()
    {
        /*Write a program that reads from the console a sequence of N integer
         * numbers and returns the minimal and maximal of them.*/

        Console.Write("How many numbers? : ");
        int n = int.Parse(Console.ReadLine());

        int[] intArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Input number {0}: ",i+1);
            intArray[i] = int.Parse(Console.ReadLine());           
        }

        Console.WriteLine("The maximum number is {0} and the minimum {1}", intArray.Max(), intArray.Min());
    }
}

