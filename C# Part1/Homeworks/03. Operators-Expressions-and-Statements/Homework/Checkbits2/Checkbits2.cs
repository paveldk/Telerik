using System;

class CheckBits
{
    static void Main()
    {
        Console.Write("Input a number:");
        int Number = int.Parse(Console.ReadLine());
        Console.Write("Input bit number :");
        int Bit = int.Parse(Console.ReadLine());
        int i = 1;
        int mask = i << Bit;

        Console.WriteLine("Is the bit{0} of {1} a \"1\"?", Bit, Number);
        Console.WriteLine((Number & mask) != 0 ? "True" : "False");
    }
}