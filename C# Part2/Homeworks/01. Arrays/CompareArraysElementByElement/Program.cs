/*Write a program that reads two arrays from the console and compares them element by element.
 **/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Input lenght of array 1: ");
        int temp = int.Parse(Console.ReadLine());
        int[] array1 = new int[temp];

        Console.Write("Input lenght of array 2: ");
        temp = int.Parse(Console.ReadLine());
        int[] array2 = new int[temp];

        if (array1.Length==array2.Length) //equal lenghts
        {
            for (int i = 0; i < array1.Length; i++) //input elements for array1
            {
                Console.Write("Input element {0} of array 1: ",i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array2.Length; i++)//input elements for array2
            {
                Console.Write("Input element {0} of array 2: ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array1); //sorting arrays for proper compare
            Array.Sort(array2);

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])//compare elements, if equal the loop will continue, if not gonna print Not equal and stop the program
                {
                    Console.WriteLine("Not equal");
                    Environment.Exit(0);
                }              
            }
            Console.WriteLine("Arrays are equal");
        }
        else //if lenghts aren't equal, the arrays aren't too.
        {
            Console.WriteLine("Not equal");
        }
    }
}

