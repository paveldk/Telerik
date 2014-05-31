using System;
class nFactorialDevideByKFactorial
{
    static void Main()
    {
        /*Write a program that calculates N!/K! for given N and K (1<K<N).*/
        int k = 0;
        int n = 0;
        ulong result = 1;
        do
        {
            Console.Write("Input k (k>1): ");
            k = int.Parse(Console.ReadLine());    
        } while (k<=1);

        do
        {
            Console.Write("Input n (n>k): ");
            n = int.Parse(Console.ReadLine());    
        } while (n<=k);

        for (int i = k+1; i <= n; i++)
        {
            result *= (ulong)i;   
        }

        Console.WriteLine("The sum of N!/K!={0}",result);
        
    }
}

