using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        /*Write a program that calculates for given N how many trailing zeros
         * present at the end of the number N!.*/
        Console.Write("Input N: ");
        int n = int.Parse(Console.ReadLine());

        //To work with 50000 or more we need to use BigInteger style!
        BigInteger result = new BigInteger();

        result = 1;
       
        for (int i = 1; i <= n; i++)
        {
            result *= (BigInteger)i;
        }

        string strResult = "" + result;
        int count = 0;

        for (int i = strResult.Length-1 ; i > 0; i--)
        {
            if (strResult[i]!='0')
            {
                break;
            }
            count += 1;
        }

        Console.WriteLine(result);
        Console.WriteLine(count);
    }
}
