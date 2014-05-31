using System;

class PrintNIntegers
{
    static void Main()
    {
        //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

        Console.Write("Input the number : ");
        long number = long.Parse(Console.ReadLine());
        string count = number.ToString(); 

        for (int i = 0; i < count.Length; i++)
        {
            Console.WriteLine(count[i]);    
        }

    }
}
