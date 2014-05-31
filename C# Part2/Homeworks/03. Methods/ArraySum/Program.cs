/*Task 8: Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
 * For this task I used some advice from Forum, while adding user's choice about lenght of the arrays.
 */

using System;

internal class Program
{
    private static void Main()
    {
        Console.Write("Lenght of array 1 :");
        int length = int.Parse(Console.ReadLine());

        byte[] arrayOfNumbers1 = new byte[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            arrayOfNumbers1[i] = (byte)random.Next(0, 9);
        }

        Console.WriteLine("Reversed array 1:");

        for (int i = length - 1; i >= 0; i--)
        {
            Console.Write(arrayOfNumbers1[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Lenght of array 2 :");
        length = int.Parse(Console.ReadLine());

        byte[] arrayOfNumbers2 = new byte[length];

        for (int i = 0; i < length; i++)
        {
            arrayOfNumbers2[i] = (byte)random.Next(0, 9);          
        }

        Console.WriteLine("Reversed array 2:");

        for (int i = length - 1; i >= 0; i--)
        {
            Console.Write(arrayOfNumbers2[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("The sum of array1 and array 2 is:");

        PrintSum(arrayOfNumbers1, arrayOfNumbers2);
    }

    private static void PrintSum(byte[] number1, byte[] number2)
    {
        int maxRange = Math.Max(number1.Length, number2.Length);

        Array.Resize(ref number1, maxRange);
        Array.Resize(ref number2, maxRange);
        byte[] sum = new byte[maxRange + 1];

        bool carry = false;
        for (int i = 0; i < maxRange; i++)
        {
            var currentSum = (byte)(number1[i] + number2[i]);

            if (carry)
            {
                currentSum += 1;
                carry = false;
            }

            if (currentSum > 9)
            {
                carry = true;
                sum[i] = (byte)(currentSum % 10);
            }
            else
            {
                sum[i] = currentSum;
            }
        }

        // Add leading 1
        if (carry)
        {
            sum[maxRange] = 1;
        }

        // Remove leading zero
        if (!carry)
        {
            Array.Resize(ref sum, sum.Length - 1);
        }

        for (int i = sum.Length - 1; i >= 0; i--)
        {
            Console.Write(sum[i] + " ");    
        }

        Console.WriteLine();
    }  
}