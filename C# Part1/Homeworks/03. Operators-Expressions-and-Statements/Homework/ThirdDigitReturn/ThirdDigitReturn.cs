using System;

class ThirdDigitReturn
{
    static void Main()
    {
        Console.Write("Input a four digit number:");
        int Number = int.Parse(Console.ReadLine());
        int Number1 = Number / 100;
        Number = Number1 % 10;
        Console.WriteLine("Is the third digit(Right to left) of the number 7()?");
        Console.ReadLine();
        if (Number == 7)
        {
            Console.WriteLine("Yes");    
        }
        else
        {
            Console.WriteLine("No"); 
        }
    }
}
