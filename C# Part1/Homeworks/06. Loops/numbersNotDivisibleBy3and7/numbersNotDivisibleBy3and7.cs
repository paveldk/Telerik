using System;

class numbersNotDivisibleBy3and7
{
    static void Main()
    {
        /*Write a program that prints all the numbers from 1 to N, that are not
         * divisible by 3 and 7 at the same time*/

        Console.Write("Input N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Numbers from 1 to {0} hat are not divisible by 3 and 7 at the same time:", n);
        for (int i = 1; i <= n; i++)
        {
            if (!((i%3==0) && (i%7==0)))
            {
                Console.WriteLine(i);
            }
        }
    }
}

