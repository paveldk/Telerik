// Write a method that reverses the digits of given decimal number. Example: 256  652
using System;

class Program
{
    static void Main()
    {
        Console.Write("Number: ");
        string number = Console.ReadLine();
        Console.WriteLine("The reverse is {0}.", ReverseDigits(number));
    }

    static string ReverseDigits(string number)
    {
        string temp = string.Empty;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            temp = temp + number[i];       
        }

        return temp;

        // or that way:
        // char[] temp = number.ToCharArray();
        // Array.Reverse(temp);
        // return new string(temp);
        // Since we're using low count numbers I prefer fastest way with loop.
    }
}
