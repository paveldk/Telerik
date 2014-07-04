/*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

 * */
using System;

class Program
{
    static void Main()
    {
        Console.Write("Input array length: ");
        int N = int.Parse(Console.ReadLine());
        
        
        Console.Write("Input number of variation: ");
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[K];

        printArray(array, 0);
    }

    static void printArray(int[] array, int start)
    {
        if (start==array.Length)//if start is equal to array lenght it's to the end time for print
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();    
        }
        else //if not array[0](in the beggining) get's value of one, then recursion with start +1 that's gonna fill the array with 1,1 first time for 3,2 we gonan reach the array lenght(2) and gonna print 1,1. Then we gonna increase i and the second value of the array gonna be come 2 and so on...
        {
            for (int i = 1; i <= array.Length; i++)
            {
                array[start] = i;
                printArray(array, start + 1);
            }
        }
    }
}

