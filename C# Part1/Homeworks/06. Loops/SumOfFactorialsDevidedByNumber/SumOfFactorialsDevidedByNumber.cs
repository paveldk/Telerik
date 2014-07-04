using System;

class FactorialCalculation
{
    static void Main()
    {
        /*Write a program that, for a given two integer numbers N and X, 
         * calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N*/


        decimal sum = 1;
        ulong factorial = 1;
        ulong power = 0;
        Console.Write("Input n : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Input x: ");
        int x = int.Parse(Console.ReadLine());


        for (int i = 1; i <= n; i++)
        {
            factorial *= (ulong)i;
            power = (ulong)(Math.Pow(x, i));
            sum += factorial /(decimal)power;
        }


        Console.WriteLine("The sum of N!*K!/(K-N)!={0}", sum);

    }
}

