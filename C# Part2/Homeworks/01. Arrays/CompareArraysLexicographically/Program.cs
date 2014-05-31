/*Write a program that compares two char arrays lexicographically (letter by letter).
 * Becouse it's pretty much the same like the Task 2, gonna make it how it's in the Nakov's book - to print which array is first Lexicographically - the array, whose element is smaller (comes earlier in the alphabet), comes first.
 **/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Input lenght of array 1: ");
        int temp = int.Parse(Console.ReadLine());
        char[] array1 = new char[temp];

        Console.Write("Input lenght of array 2: ");
        temp = int.Parse(Console.ReadLine());
        char[] array2 = new char[temp];

        if (array1.Length == array2.Length) //equal lenghts
        {
            for (int i = 0; i < array1.Length; i++) //input elements for array1
            {
                Console.Write("Input element {0} of array 1: ", i);
                array1[i] = Convert.ToChar(Console.ReadLine());
            }

            for (int i = 0; i < array2.Length; i++)//input elements for array2
            {
                Console.Write("Input element {0} of array 2: ", i);
                array2[i] = Convert.ToChar(Console.ReadLine());
            }

            Array.Sort(array1); //sorting arrays for proper compare
            Array.Sort(array2);

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i])//compare elements
                {
                    Console.WriteLine("Array 2 is first");
                    Environment.Exit(0);
                }
                else if (array1[i] < array2[i])
                {
                    Console.WriteLine("Array 1 is first");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Arrays are equal");
        }
        else //if lenghts aren't equal, comprate which is longer
        {
            if (array1.Length>array2.Length)
            {
                Console.WriteLine("Array 2 is first");   
            }
            else
            {
                Console.WriteLine("Array 1 is first");
            }
            
        }
    }
}

