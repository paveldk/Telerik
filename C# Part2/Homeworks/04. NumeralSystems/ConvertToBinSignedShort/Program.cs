// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;

class Program
{
    static void Main()
    {
        short decimalNumber = 0;
        string input = string.Empty;
        bool isShort = false;
        do
        {
            // I'm using part of the code from first task, simply changed the type from long to short, corresponding to the task condition
            Console.Clear();
            string title = "Convert Decimal to Binary";
            int titleLength = (Console.WindowWidth - title.Length) / 2;
            Console.WriteLine("{0}{1}{0}", new string('-', titleLength), title);
            Console.Write("Input a short value: ");
            input = Console.ReadLine();
            isShort = short.TryParse(input, out decimalNumber);
        }
        while (!isShort);

        // When proper value is inputed(for this case a short one) we call the Method 
        decimalNumber = Convert.ToInt16(input);
        string result = ConvertFromDecimal(decimalNumber);
        Console.WriteLine("The binary represantation of long number {0} is {1}", decimalNumber, result);  
    }

    static string ConvertFromDecimal(short decimalNumber)
    {
        short remainder;
        string result = string.Empty;
        bool negative = false;

        // if the number is negative we add to it's value the minimum value for short numbers
        if (decimalNumber < 0)
        {
            decimalNumber = (short)(decimalNumber + short.MinValue);
            negative = true;
        }

        // then we delete to the numeric system we want and get the reminder
        while (decimalNumber > 0)
        {
            remainder = (short)(decimalNumber % 2);
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }

        // we need to add one "1" for sign if the number is negative.
        if (negative == true)
        {
            result = "1" + result;
        }

        return result;
    }
}
