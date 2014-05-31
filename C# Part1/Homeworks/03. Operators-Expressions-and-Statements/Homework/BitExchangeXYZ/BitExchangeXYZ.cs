using System;

class BitExchangeXYZ
{
    static void Main()
    {
        Console.Write("Input a integer:");
        int Number = int.Parse(Console.ReadLine());

        Console.Write("Input first start bit for exchange: ");
        int firstbit = int.Parse(Console.ReadLine());

        Console.Write("Input second start bit for exchange: ");
        int secondbit = int.Parse(Console.ReadLine());

        Console.Write("How many bits you want to exchange: ");
        int bitcount = int.Parse(Console.ReadLine());

        int mask345 = 0;
        int mask242526 = 0;

        for (int i = firstbit; i < firstbit+bitcount; i++)
        {
            mask345 = mask345 | (1 << i);
            mask242526 = mask242526 | (1 << i + secondbit - firstbit);           
        }

        int Nmask345 = Number & mask345;
        int Nmask242526 = Number & mask242526;

        Number = (~mask242526 & Number) | (Nmask345 << secondbit - firstbit);
        Number = (~mask345 & Number) | (Nmask242526 >> secondbit - firstbit);

        Console.WriteLine(Number);
    }
}