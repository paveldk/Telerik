using System;

class DivisionByFive
{
    static void Main()
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

        Console.Write("Input first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Input second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        
        int count = 0;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                count += 1;    
            }    
        }

        Console.WriteLine("The count of the numbers between {0} and {1} that can be devided by 5 equaly is {2}", firstNumber, secondNumber, count);
   }
}
