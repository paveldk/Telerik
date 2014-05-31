using System;

class fibonacciSequence
{
    static void Main()
    {
        /*Write a program that reads a number N and calculates the sum of the
         * first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 
         * 13, 21, 34, 55, 89, 144, 233, 377, …*/


        Console.Write("The sum of how many numbers from Fibonacci sequence you want to be printed? : ");
        int last = int.Parse(Console.ReadLine());
        ulong numberOne = 0;
        ulong numberTwo = 1;
        ulong sum = 0;

        for (int i = 0; i <= last - 2; i++)
        {
            /*The first and second number in Fibonacci sequence are 0 and 1. 
             * Every next number is equal to previous two. That's why i'm giving
             * value to the first two, then i'm using one temp variable to store
             * numberOne, becouse just after that i'm increasint numberone with 
             * the value of numberTwo. Then numberTwo is getting the value of 
             * Number one and that N-2 times(first two are 0 and 1). */

            ulong temp = numberOne;
            numberOne = numberOne + numberTwo;
            numberTwo = temp;
            sum = sum + numberOne;
        }

        Console.WriteLine("The sum is {0}",sum);

    }
}
