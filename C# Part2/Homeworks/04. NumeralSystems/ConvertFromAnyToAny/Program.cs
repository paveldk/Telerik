// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
using System;

class Program
{
    static void Main()
    {
        Console.Write("Choose numeral system to transfer FROM(from 2 to 16): ");
        int numeralFrom = int.Parse(Console.ReadLine());

        // I'm not gonna check if the numbers are OK here, simply becouse I add too many efforts in the previous task, so i'm gonna hope user is friendly in his inputs :P
        Console.Write("Choose the number(proper number for the choosen numeral system!): ");
        string number = Console.ReadLine();

        Console.Write("Choose numeral system to transfer To(from 2 to 16): ");
        int numeralTo = int.Parse(Console.ReadLine());

        // What i'm doing is to use two of the methods from previous task 
        
        // First to convert from any given FROM numeral to Decimal
        long toDecimal = ConvertToDecimal(number, numeralFrom);

        // And then from Decimal to given TO
        string result = ConvertFromDecimal(toDecimal, numeralTo);

        // And we print result:
        Console.WriteLine("The value in {0} numeral system for {1}({2} numeral system) is {3}", numeralTo, number, numeralFrom, result);
    }

    static long ConvertToDecimal(string binaryNumber, int numeric)
    {
        long result = 0;
        int multiplier = 1;

        binaryNumber = binaryNumber.TrimStart('-');
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            result = result + ((long)(binaryNumber[i] - 48) * multiplier);
            multiplier *= numeric;
        }

        // For Decimal numbers ff the length is 64 bit(long value) and the leading is 1 so we want negative number that's why in this case we add to result the min value for the long
        if (binaryNumber.Length == 64 && binaryNumber[0].Equals('1') && numeric == 2)
        {
            return long.MinValue + result;
        }
        else
        {
            return result;
        }
    }

    // This method is for convert FROM decimal to any other, in our case to Hex and Bin. Method works with devinding a number to it's numeric base and getting the remainder of this action. 
    static string ConvertFromDecimal(long decimalNumber, int numeric)
    {
        long remainder;
        string result = string.Empty;
        bool negative = false;

        // if the number is negative we add to it's value the minimum value for long numbers
        if (decimalNumber < 0)
        {
            decimalNumber = decimalNumber + long.MinValue;
            negative = true;
        }

        // then we delete to the numeric system we want and get the reminder, if the reminder is bigger than 9(Hex) we convert it to letter
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % numeric;
            decimalNumber /= numeric;
            if (remainder > 9)
            {
                switch (remainder)
                {
                    case 10:
                        result = "A" + result;
                        break;
                    case 11:
                        result = "B" + result;
                        break;
                    case 12:
                        result = "C" + result;
                        break;
                    case 13:
                        result = "D" + result;
                        break;
                    case 14:
                        result = "E" + result;
                        break;
                    case 15:
                        result = "F" + result;
                        break;
                    default:
                        break;
                }        
            }
            else
            {
                result = remainder.ToString() + result;
            }          
        }

        // if we convert to Decimal and the number is negative we need to add one "1" for sign.
        if (numeric == 2 && negative == true)
        {
            result = "1" + result;                
        }

        // if we convert to Hex and the number is negative we need to remove one leading "7"
        if (numeric == 16 && negative == true)
        {
            result = result.TrimStart('7');
        }

        return result;
    }
}
