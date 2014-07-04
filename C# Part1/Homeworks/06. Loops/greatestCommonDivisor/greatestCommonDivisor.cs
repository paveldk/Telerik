using System;

class greatestCommonDivisor
{
    static int gcd(int x, int y)
    {
        /* Version with recursion:
         * Taking both of the input numbers of the key x and y, determine 
         * whether y is equal to 0. If so, the number x is the desired greatest
         * common divisor. If not, repeat the process as used for input y and 
         * the residue obtained by dividing x to y (referred to below with x % 
         * y) */
        if (y == 0)
        {
            return x;
        }
        else
        {
            return gcd(y, x % y);
        }
    }

    static void Main()
    {
        /*Write a program that calculates the greatest common divisor (GCD) of 
         * given two numbers. Use the Euclidean algorithm (find it in 
         * Internet).*/

        Console.Write("Input number 1: ");
        int numberOne = int.Parse(Console.ReadLine());

        Console.Write("Input number 2: ");
        int numberTwo = int.Parse(Console.ReadLine());

        Console.WriteLine(gcd(numberOne, numberTwo));

        /* That is version with lopp :
        do
        {
            int temp = numberTwo;
            numberTwo = numberOne % numberTwo;
            numberOne = temp;

        } while (numberTwo != 0);


        Console.WriteLine(numberOne);
        */

    }
}
