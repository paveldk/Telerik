using System;

class Bitextracting
{
    static void Main()
    {
        Console.Write("Input a integer:");
        int Number = int.Parse(Console.ReadLine());
        Console.Write("Input bit number :");
        int Bit = int.Parse(Console.ReadLine());
        int i = 1;
        int mask = i << Bit;

        if ((Number & mask) != 0)
        {
            Console.WriteLine("The bit{0} of {1} is 1.", Bit, Number);
        }
        else
        {
            Console.WriteLine("The bit{0} of {1} is 0.", Bit, Number);
        }
    }
}