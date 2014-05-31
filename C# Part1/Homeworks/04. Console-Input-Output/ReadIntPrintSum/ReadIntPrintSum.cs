using System;

class ReadIntPrintSum
{
    static void Main()
    {
        //Write a program that reads 3 integer numbers from the console and prints their sum.

        Console.Write("Input first number: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Input third number: ");
        int numberThree = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the three numbers is : "+(numberOne+numberTwo+numberThree));
    }
}
