using System;

class sumOfFraction
{
    static void Main()
    {
        //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

        decimal sum = 1m;
        decimal sumTemp = 0m;
        decimal i = 2m;
        decimal difference;
        do
        {
            sumTemp = sum;
            if (i%2==0)
            {
                sum = sum + (1 / (decimal)i);        
            }
            else
            {
                sum = sum - (1 / (decimal)i);
            }
        
            i++;
            difference = Math.Abs(sum - sumTemp);

        } while (Decimal.Compare(difference, 0.001M) > 0);

        Console.WriteLine("The sum is {0:F3}", sum);

    }
}