// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.
using System;

class Program
{
    static void Main()
    {
        // This task is easy - we just need to use params
        Console.WriteLine("Sum: {0}", CalcSum(4, 0, -2, 12));
        Console.WriteLine("Min: {0}", FindMin(4, 0, -2, 12));
        Console.WriteLine("Max: {0}", FindMax(4, 0, -2, 12));
        Console.WriteLine("Product: {0}", CalcProduct(4, 0, -2, 12));
    }

    static decimal CalcSum(params decimal[] elements)
    {
        decimal sum = 0;
        foreach (decimal element in elements)
        {
            sum += element;
        }
            
        return sum;
    }

    static decimal CalcProduct(params decimal[] elements)
    {
        decimal product = 1;
        foreach (decimal element in elements)
        {
            product *= element;
        }
            
        return product;
    }

    static decimal FindMin(params decimal[] elements)
    {
        decimal min = decimal.MaxValue;
        foreach (decimal element in elements)
        {
            if (element < min)
            {
                min = element;
            }
        }

        return min;
    }

    static decimal FindMax(params decimal[] elements)
    {
        decimal max = decimal.MinValue;
        foreach (decimal element in elements)
        {
            if (element > max)
            {
                max = element;
            }
        }

        return max;
    }

    static decimal FindAvg(params decimal[] elements)
    {
        decimal sum = 0;
        decimal count = 0;
        foreach (decimal element in elements)
        {
            sum += element;
            count++;
        }
            
        return sum / count;
    }
}
