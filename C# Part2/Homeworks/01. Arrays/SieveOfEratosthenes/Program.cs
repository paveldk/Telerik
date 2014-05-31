/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
*/
using System;

class Program
{
    static void Main()
    {
        long n = 10000000; 
        bool[] array = new bool[n]; //by default they're all false

        //we need out the non primes by finding mutiplies 
        for (int j = 2; j < n; j++)
        {
            if (!array[j])//is false
            {
                for (long p = 2; (p * j) < n; p++)
                {
                    array[p * j] = true;
                }
            }
        }

        //print the numbers
        for (int i = 0; i < array.Length; i++)
        {
            if (!array[i])
            {
                Console.Write(i+" ");
            }    
        }
        
    }
}

