/* Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
 * x2 + 5 = 1x2 + 0x + 5 
 * Extend the program to support also subtraction and multiplication of polynomials.
 * Both 11 and 12 in one task.
 */
using System;

class Program
{
    static void Main()
    {
        // Polynomial 1
        Console.Write("Max index of polynomial 1 : ");
        int length = int.Parse(Console.ReadLine());

        decimal[] polynomial1 = new decimal[length];

        for (int i = length - 1; i >= 0; i--)
        {
            Console.Write("Value for x^[{0}]: ", i);
            polynomial1[i] = decimal.Parse(Console.ReadLine());
        }
       
        Console.Write("The polynomial 1 is:                           ");
        PrintPolynomial(polynomial1);

        Console.WriteLine();
        Console.WriteLine();
        
        // Polynomial 2
        Console.Write("Max index of polynomial 2 : ");
        length = int.Parse(Console.ReadLine());

        decimal[] polynomial2 = new decimal[length];

        for (int i = length - 1; i >= 0; i--)
        {
            Console.Write("Value for x^[{0}]: ", i);
            polynomial2[i] = decimal.Parse(Console.ReadLine());
        }

        Console.Write("The polynomial 2 is:                           ");
        PrintPolynomial(polynomial2);
        Console.WriteLine();
        Console.WriteLine();

        // we get for lenght longest of the start arrays.
        length = Math.Max(polynomial1.Length, polynomial2.Length);

        decimal[] result = new decimal[length];

        Console.Write("The sum of the polynomials:                    ");
        PolynomialSum(polynomial1, polynomial2, result);
        Console.WriteLine();

        result = new decimal[length];
        Console.Write("The substraction of the polynomials:           ");
        PolynomialSubstraction(polynomial1, polynomial2, result);
        Console.WriteLine();

        result = new decimal[polynomial1.Length + polynomial2.Length];
        Console.Write("The multiplication of the polynomials:         ");
        PolynomialMultiply(polynomial1, polynomial2, result);
        Console.WriteLine();
    }

    static void PrintPolynomial(decimal[] polynomial)
    {
        Console.Write("y=");
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if ((i != 0) && (polynomial[i] != 0))
            {
                if (polynomial[i - 1] > 0)
                {
                    // if The element isn't las one, index 0 or next element isn't 0 itself we print the value AND +
                    Console.Write("{0}x^{1}+", polynomial[i], i); 
                }
                else
                {
                    // otherwise only value
                    Console.Write("{0}x^{1}", polynomial[i], i);
                }
            }
            else if (i == 0)
            {
                if (polynomial[i] != 0)
                {
                    // if we're at the last element which is x^0 we don't need it, we need only the number itself and no + after it(last element).
                    Console.Write("{0}", polynomial[i]);    
                }              
            }
        }
    }

    static void PolynomialSum(decimal[] polynomial1, decimal[] polynomial2, decimal[] result)
    {       
        for (int i = 0; i < result.Length; i++)
        {
            // On sum we make sums till there is elements in start arrays.
            if (i < polynomial1.Length)
            {
                result[i] = result[i] + polynomial1[i];    
            }

            if (i < polynomial2.Length)
            {
                result[i] = result[i] + polynomial2[i];
            } 
        }

        PrintPolynomial(result);
    }

    static void PolynomialSubstraction(decimal[] polynomial1, decimal[] polynomial2, decimal[] result)
    {
        for (int i = 0; i < result.Length; i++)
        {
            if ((i < polynomial1.Length) && (i < polynomial2.Length))
            {
                // While BOTH arrays have elements we substract elements from array2 from the elements from array1
                result[i] = polynomial1[i] - polynomial2[i];
            }
            else if (i < polynomial1.Length)
            {
                // when(if) one of the ends we simply gets the element from the left array
                result[i] = polynomial1[i];     
            }
            else
            {
                result[i] = 0 - polynomial2[i]; 
            }
        }

        PrintPolynomial(result);
    }

    static void PolynomialMultiply(decimal[] polynomial1, decimal[] polynomial2, decimal[] result)
    {
        for (int i = 0; i < polynomial1.Length; i++)
        {
            for (int j = 0; j < polynomial2.Length; j++)
            {
                // on Multiply for index we get the index from first array PLUS index from second and for value the value from first MULTIPLY the value of second. Since the length here is sum from the lenght of the first+second we don't need to check if there is still elements in the starting arrays. 
                int position = i + j;
                result[position] += polynomial1[i] * polynomial2[j];
            }
        }

        PrintPolynomial(result);
    }
}