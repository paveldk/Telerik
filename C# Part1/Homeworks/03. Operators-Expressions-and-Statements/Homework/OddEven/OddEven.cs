using System;

class OddEven
{
    static void Main()
    {
        Console.Write("Input a number:");
        int Number = int.Parse(Console.ReadLine());
        if ((Number % 2) == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
	    {
            Console.WriteLine("The number is odd.");
	    }
    }
}
