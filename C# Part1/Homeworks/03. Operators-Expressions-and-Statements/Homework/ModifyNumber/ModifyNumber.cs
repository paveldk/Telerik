using System;

class ModifyNumber
{
    static void Main()
    {
        Console.Write("Input a integer:");
        int Number = int.Parse(Console.ReadLine());
        /*bool fl = false;
        int Bit;
        while (fl==false)
        {
            Console.Write("Input a boolean(1 or 0):");
            Bit = int.Parse(Console.ReadLine());
            if ((Bit!=1) && (Bit!=0))
            {
                Console.WriteLine("Please don't input numbers different from 1 or 0!");
            }
            else
            {
                fl = true;    
            }
        }*/
        Console.Write("Input a boolean(1 or 0):");
        int Bit = int.Parse(Console.ReadLine());

        Console.Write("Input a position:");
        int Pos = int.Parse(Console.ReadLine());

        if (Bit==0)
        {
            Number = Number & (~(1 << Pos));
            Console.WriteLine(Number);
        }
        else
        {
            Number = Number | ((1 << Pos));
            Console.WriteLine(Number);
        }
        
    }
}