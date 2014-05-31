using System;

class greaterNumberWithoutIf
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.


        Console.Write("Input first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Input second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        

        Console.WriteLine("Greatest number is: {0}", Math.Max(firstNumber, secondNumber));
    }
}
