using System;
using System.Numerics;


class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        BigInteger oddsum = 0;
        BigInteger evensum = 0;

        number = number.TrimStart('0');
        number = number.TrimStart('-');

        for (int i = 0; i < number.Length; i++)
        {
            int currentdigit = Convert.ToInt32("" + number[i]);
            if ((currentdigit % 2) == 0)
            {
                evensum = evensum + currentdigit;       
            }
            else
            {
                oddsum = oddsum + currentdigit;
            }
        }

        if (evensum>oddsum)
        {
            Console.WriteLine("right {0}", evensum);    
        }

        if (oddsum>evensum)
        {
            Console.WriteLine("left {0}", oddsum);    
        }

        if (evensum==oddsum)
        {
            Console.WriteLine("straight {0}", evensum);    
        }

    }
}

