using System;

class CatalanNumbers
{
    static void Main()
    {
        /*In the combinatorial mathematics, the Catalan numbers are calculate by
         * the following formula: (2*n)!/(n+1)!*n!
         * Write a program to calculate the Nth Catalan number by given N. */

        Console.Write("Input N: ");
        int n = int.Parse(Console.ReadLine());
        decimal result = 1;
        decimal nfact = 1;

        //we devide the formula to 1/n! and (2*n)!/(n+1)! Second one is loop from (n+1)+1 to 2*n :

        for (int i = n+2; i <= 2*n; i++)
        {
            result *= i;
        }

        //the other part is simple loop 1 to n
        for (int i = 1; i <=n; i++)
        {
            nfact *= i;
        }
 
        Console.WriteLine("The sum is {0}", result/nfact);

    }
}
