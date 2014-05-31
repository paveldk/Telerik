using System;

class BonusScore
{
    static void Main()
    {
        //Write a program that applies bonus score to a given score in the range [1..9]. The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; if it's between 4 and 6 it multiplies it by 100; if it's between 7 and 9 by 1000. If it's zero or if the value isn't a digit the value report an error. Use a switch statement and print the calculated new value in the console

        Console.Write("Input value: ");
        string strvalue = Console.ReadLine();
        int value; 

        if (int.TryParse(strvalue, out value))
        {
            switch (value)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(value*10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(value * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(value * 1000);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error");
        }



    }
}
