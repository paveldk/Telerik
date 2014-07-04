using System;

class Program
{
    static void Main()
    {
        int Number = int.Parse(Console.ReadLine());

        int remainder;
        string result = string.Empty;

        while (Number > 0)
        {
            remainder = Number % 2;
            Number /= 2;
            result = remainder.ToString() + result;
        }

        string temp = "";

        if (result.Length>16)
        {
            for (int i = result.Length-1; i >=result.Length-16; i--)
            {
                temp = result[i]+temp;    
            }    
        }
        else
        {
            temp = result;
            for (int i = 0; i < 16 - result.Length; i++)
            {
                temp = "0" + temp;
            }
        }
        


        result = temp;

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == '0')
            {
                Console.Write("###");   
            }
            else
            {
                Console.Write(".#."); 
            }
            if (i != result.Length-1)
            {
                Console.Write(".");   
            }
        }
        Console.WriteLine();

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == '0')
            {
                Console.Write("#.#");
            }
            else
            {
                Console.Write("##.");
            }
            if (i != result.Length - 1)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == '0')
            {
                Console.Write("#.#");
            }
            else
            {
                Console.Write(".#.");
            }
            if (i != result.Length - 1)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == '0')
            {
                Console.Write("#.#");
            }
            else
            {
                Console.Write(".#.");
            }
            if (i != result.Length - 1)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == '0')
            {
                Console.Write("###");
            }
            else
            {
                Console.Write("###");
            }
            if (i != result.Length - 1)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
    }
}

