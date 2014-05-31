using System;

class CheckBits
{
    static void Main()
    {
        Console.Write("Input a number:");
        int Number = int.Parse(Console.ReadLine());
        if ((Number&8) == 0)
        {
            Console.WriteLine("Bit 3 of {0} is 0", Number);    
        }
        else
        {
            Console.WriteLine("Bit 3 of {0} is 1", Number); 
        }
    }
}