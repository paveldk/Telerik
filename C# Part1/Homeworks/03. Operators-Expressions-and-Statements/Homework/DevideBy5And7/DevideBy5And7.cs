using System;

class DevideBy5And7
{
    static void Main()
    {
        Console.Write("Input a number:");
        int Number = int.Parse(Console.ReadLine());
        if (((Number % 5) == 0) ||((Number % 7) == 0)) 
        {
            Console.WriteLine("The number can be devided by 5 and 7 exactly.");
        }
        else
        {
            Console.WriteLine("The number cannot be devided by 5 and 7 exactly.");
        }
    }
}