/*Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 * */
using System;
class Program
{
    static void Main()
    {
        Console.Write("Input array length: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++) //input elements for array
        {
            Console.Write("Input element {0} of array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Input the sum: ");
        int sum = int.Parse(Console.ReadLine());
        int currentsum = 0;

        for (int i = 0; i < array.Length; i++)//two loops, one from begin to end, second from the index of the first to end, that's how we get all possible sequence
        {
            currentsum = 0;//everytime our current sum is 0
            for (int j = i; j < array.Length; j++)
            {
                if (currentsum==sum)//if at some point the current sum is equal to searching one we print the array from i to j element - start element and to the element where the sum is equal.
                {
                    for (int k = i; k < j; k++)
                    {
                        Console.Write(array[k] + " ");                        
                    }
                    Console.WriteLine();
                    Environment.Exit(0);//and we exit
                }
                else
                {
                    currentsum += array[j];
                }              
            }   
        }

        Console.WriteLine("There is no such subsum.");//if we exit from first loop, so there is no such subsum - we print it.
    }
}
