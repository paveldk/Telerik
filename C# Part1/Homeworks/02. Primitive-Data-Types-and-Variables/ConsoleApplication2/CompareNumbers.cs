using System;

class CompareNumbers
{
    static void Main()
    {
        Console.Write("Please input number 1:");
        decimal Number1 = decimal.Parse(Console.ReadLine());

        Console.Write("Please input number 2:");
        decimal Number2 = decimal.Parse(Console.ReadLine());

        decimal Result=Number1-Number2;

        if ((Result > -0.000001m) || (Result < 0.000001m))
        {
            Console.WriteLine("The numbers {0} and {1} are equal", Number1, Number2); 
        }
        else
	    {
            Console.WriteLine("The numbers {0} and {1} aren't equal", Number1, Number2); 
	    }
    }
}
