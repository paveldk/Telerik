// * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Similar to previous task but instead of specific types we use T for generic
        Console.WriteLine("Sum: {0}", CalcSum("4.5", "dsff", "-2", "12"));
        Console.WriteLine("Min: {0}", FindMin(4.5, 0, -2, 12));
        Console.WriteLine("Max: {0}", FindMax(4, 0, -2, 12));
        Console.WriteLine("Product: {0}", CalcProduct(4, 0, -2, 12));
    }

    static T CalcSum<T>(params T[] elements)
    {
        dynamic sum = 0;
        foreach (dynamic element in elements)
        {
            sum += element;
        }
            
        return sum;
    }

    static T CalcProduct<T>(params T[] elements)
    {
        dynamic product = 1;
        foreach (dynamic element in elements)
        {
            product *= element;
        }
            
        return product;
    }

    static T FindMin<T>(params T[] elements)
    {
        dynamic min = elements[0];
        foreach (dynamic element in elements)
        {
            if (element < min)
            {
                min = element;
            }
        }

        return min;
    }

    static T FindMax<T>(params T[] elements)
    {
        dynamic max = elements[0];
        foreach (dynamic element in elements)
        {
            if (element > max)
            {
                max = element;
            }
        }

        return max;
    }

    static T FindAvg<T>(params T[] elements)
    {
        dynamic sum = 0;
        dynamic count = 0;
        foreach (dynamic element in elements)
        {
            sum += element;
            count++;
        }

        return sum / count;
    }
}