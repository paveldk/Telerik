using System;
using System.Linq;

class BiggestFromFive
{
    static void Main()
    {
        //Write a program that finds the greates of given 5 variables
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The biggest number is {0}", numbers.Max());

    }
}
