using System;

class FactorialCalculation
{
    static void Main()
    {
        /*Write a program that calculates N!*K! / (K-N)! for given N and K
         * (1<N<K).*/
        int k = 0;
        int n = 0;
        ulong result = 1;

        do
        {
            Console.Write("Input n (k>1): ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 1);

        do
        {
            Console.Write("Input k (n>k): ");
            k = int.Parse(Console.ReadLine());
        } while (k <= n);

        //The sum of N!*K! / (K-N)! is N! * (K!/(K-N)!) so N! is:

        for (int i = 1; i <= n; i++)
        {
            result *= (ulong)i;
        }

        // and adding (K!/(K-N)!):
        
        for (int i = k-n + 1; i <= k; i++)
        {
            result *= (ulong)i;
        }


        Console.WriteLine("The sum of N!*K!/(K-N)!={0}", result);

    }
}

