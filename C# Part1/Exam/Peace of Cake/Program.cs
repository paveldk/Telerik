using System;

class Program
{
    static void Main()
    {
        ulong A = ulong.Parse(Console.ReadLine());
        ulong B = ulong.Parse(Console.ReadLine());
        ulong C = ulong.Parse(Console.ReadLine());
        ulong D = ulong.Parse(Console.ReadLine());

        if ((((decimal)A / B) + ((decimal)C / D)) >= 1)
        {
            decimal result = ((decimal)A / B) + ((decimal)C / D);

            Console.WriteLine("{0}", Convert.ToInt32(result));
        }
        else
        {
            decimal result = ((decimal)A / B) + ((decimal)C / D);

            Console.WriteLine("{0:F22}", result);
        }

        ulong denominator = B * D;

        ulong nominator = (denominator / B) * A + (denominator / D) * C;

        Console.WriteLine(nominator + "/" + denominator);
    }
}