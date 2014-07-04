/*Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (GetMax(firstNumber, secondNumber) > GetMax(firstNumber, thirdNumber))
        {
            Console.WriteLine("The biggest is: {0}", GetMax(firstNumber, secondNumber));
        }
        else
        {
            Console.WriteLine("The biggest is: {0}", GetMax(firstNumber, thirdNumber));
        }
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber; // if first number is bigger - it's looking from us number
        }
        else
        {
            return secondNumber; // if not it's number 2
        }
    }
}
