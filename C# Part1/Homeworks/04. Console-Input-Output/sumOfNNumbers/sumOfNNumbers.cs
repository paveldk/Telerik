using System;

class sumOfNNumbers
{
    static void Main()
    {
        //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

        Console.Write("The ammount of how many numbers you want to calculate? : ");
        int count = int.Parse(Console.ReadLine());
        float sum = 0;
        for (int i = 0; i < count; i++)
        {
            Console.Write("Input number {0}: ", i+1);
            sum += float.Parse(Console.ReadLine());     
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}
