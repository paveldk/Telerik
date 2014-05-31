using System;

class Program
{
    static void Main()
    {
        Console.Write("Number :");
        int number = int.Parse(Console.ReadLine());
        string numberAsText = Convert.ToString(number);
        Console.WriteLine(ReturnDigitAsWord(numberAsText[numberAsText.Length - 1] - 48)); // get last digit through [Lenght-1], put it as param and in the method with switch return the word representing the digit. 
    }

    static string ReturnDigitAsWord(int digit)
    {
        // we don't need break in switch - return ends the Method
        // other way is to create Array with all of the words and to get them by there index by digit-1(index starts from 0)
        switch (digit) 
        {   
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            case 0:
                return "zero";
            default:
                return "Not a digit";
        }
    }
}