/*
 * Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger[] factorial = new BigInteger[100];
        factorial[0] = 1;
        for (int i = 1; i < 100; i++)
        {
            CalculateFactorial(factorial, i);

            Console.Write("Factorial of {0} is {1}", i + 1, factorial[i]);
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    static void CalculateFactorial(BigInteger[] factorialArray, int current)
    {
        // Just multiply previous factoriel with next number, current begins from 0 that's why we need +1
        factorialArray[current] = factorialArray[current - 1] * (current + 1);
    }
}