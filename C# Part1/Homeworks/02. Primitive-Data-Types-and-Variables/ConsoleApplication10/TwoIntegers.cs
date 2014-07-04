using System;

class TwoIntegers
{
    static void Main()
    {
        int Number1 = 5;
        int Number2 = 10;

        Console.WriteLine("x={0}, y={1}", Number1, Number2);
        Number1 = Number1 + Number2;
        Number2 = Number1 - Number2;
        Number1 = Number1 - Number2;
        Console.WriteLine("x={0}, y={1}", Number1, Number2);
    }
}
