/*Write a program that can solve these tasks:
 *      Reverses the digits of a number
 *      Calculates the average of a sequence of integers
 *      Solves a linear equation a * x + b = 0
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 *      The decimal number should be non-negative
 *      The sequence should not be empty 
 *      a should not be equal to 0
*/
using System;

class Program
{
    static void Main()
    {
        // first we create a menu with options:
        Console.WriteLine("1. Reverses the digits of a number");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0");
        Console.Write("Please choose an option :");
        int option = int.Parse(Console.ReadLine());

        // when user choose depending on his choice another manu appears
        switch (option)
        {
            case 1:
                int number = 0;

                // we validate data here
                do
                {
                    Console.Clear();
                    string temp = "Reverses the digits of a number";
                    Console.WriteLine("{0}{1}{0}", new string('-', (Console.BufferWidth - temp.Length) / 2), temp);
                    Console.Write("Choose non-negative number: ");
                    number = int.Parse(Console.ReadLine());
                }             
                while (number < 0);
                
                Console.WriteLine("The reverse is {0}.", ReverseDigits(Convert.ToString(number)));
                break;
            case 2:

                // we validate data here
                do
                {
                    Console.Clear();
                    string temp = "Calculates the average of a sequence of integers";
                    Console.WriteLine("{0}{1}{0}", new string('-', (Console.BufferWidth - temp.Length) / 2), temp);
                    Console.Write("Choose length of the sequence: ");
                    number = int.Parse(Console.ReadLine());
                }
                while (number <= 0);
                
                float avg = Avarage(number);
                Console.WriteLine("The avarage number from this sequence is {0}.", avg);

                break;

            case 3:
                float a = 0;
                float b = 0;

                // we validate data here
                do
                {
                    Console.Clear();
                    string temp = "Solves a linear equation a * x + b = 0";
                    Console.WriteLine("{0}{1}{0}", new string('-', (Console.BufferWidth - temp.Length) / 2), temp);
                    Console.Write("Choose a(not zero)= ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("Choose b= ");
                    b = float.Parse(Console.ReadLine());
                }
                while (a == 0);

                Console.WriteLine("x={0}", Linear(a, b));
                break;
            default:
                break;
        }
    }

    static string ReverseDigits(string number)
    {
        // for first option we siply need to inverse number, like in task 7
        string temp = string.Empty;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            temp = temp + number[i];
        }

        return temp;
    }

    static float Avarage(int number)
    {
        // we have similar task in previous task too
        float sum = 0;
        for (int i = 0; i < number; i++)
        {
            Console.Write("Input number {0}: ", i);
            sum = sum + int.Parse(Console.ReadLine());
        }

        return sum / number;
    }

    static float Linear(float a, float b)
    {
        // this one is simple arithmetic operation
        return -b / a;
    }
}
