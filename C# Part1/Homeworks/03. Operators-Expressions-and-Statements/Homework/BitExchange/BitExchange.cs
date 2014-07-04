using System;

class BitExchange
{
    static void Main()
    {
       Console.Write("Input a integer:");
        int Number = int.Parse(Console.ReadLine());

        int i =3;

        int mask345 = (1 << i) | (1 << i+1) | (1 << i+2);
        int mask242526 = (1 << i+21) | (1 << i+22) | (1 << i+23);

        int Nmask345 = Number & mask345;
        int Nmask242526 = Number & mask242526;

        Number = (~mask242526 & Number) | (Nmask345 << 21);
        Number = (~mask345 & Number) | (Nmask242526 >> 21);

        Console.WriteLine(Number);
    }
}