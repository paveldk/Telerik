using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Input integer:");
        int Number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i <= Math.Round(Math.Sqrt(Number)); i++)
        {
            if ((Number % i) == 0)
	        {
		        isPrime = false;    
	        }   
        }
        if (isPrime)
	    {
            Console.WriteLine("The number {0} is prime number", Number); 
	    }
        else
        {
            Console.WriteLine("The number {0} isn't prime number", Number);
        }
    }
}
