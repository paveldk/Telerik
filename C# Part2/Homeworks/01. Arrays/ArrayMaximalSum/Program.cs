/*Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.
*/
using System;
class Program
{
    static void Main()
    {
        Console.Write("Input array length: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        Console.Write("Input element for sum length: ");
        int K = int.Parse(Console.ReadLine());

        for (int i = 0; i < array.Length; i++) //input elements for array
        {
            Console.Write("Input element {0} of array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentsum = 0; //get current sum in the K
        int sum = 0;

        for (int i = 0; i <= N-K; i++)//starting two loops, one from 0 to N-K including
        {
            for (int j = i; j < K+i; j++)//second from i to K+i - exactly K rotations, but every time for next K elements. That's why previous loop is to N-K, becouse it have to stop exactly K elements before the array lenght
            {
                currentsum += array[j];//for every K elements we make subsum
            }
            if (currentsum>sum)//compare it with the final one, if bigger final get it's value
            {
                sum = currentsum;    
            }
            currentsum = 0;//reset it and start over
        }
        


        Console.WriteLine(sum);//print max one
    }
}


