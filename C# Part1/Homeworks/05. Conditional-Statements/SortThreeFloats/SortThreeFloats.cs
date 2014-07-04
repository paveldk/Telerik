using System;

class SortThreeFloats
{
    static void Main()
    {
        // Sort three real values in descending order using nested if statement

        Console.Write("Input number one: ");
        decimal numberOne = decimal.Parse(Console.ReadLine());
        Console.Write("Input number two: ");
        decimal numberTwo = decimal.Parse(Console.ReadLine());
        Console.Write("Input number three: ");
        decimal numberThree = decimal.Parse(Console.ReadLine());


        if (numberOne > numberTwo)
        {
            if (numberTwo > numberThree)
            {
                Console.WriteLine("{0} {1} {2}", numberOne, numberTwo, numberThree);
            }
            else
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine("{0} {2} {1}", numberOne, numberTwo, numberThree);
                }
                else
                {
                    Console.WriteLine("{2} {0} {1}", numberOne, numberTwo, numberThree);
                }

            }

        }
        else
        {
            if (numberOne > numberThree)
            {
                Console.WriteLine("{1} {0} {2}", numberOne, numberTwo, numberThree);
            }
            else
            {
                if (numberTwo > numberThree)
                {
                    Console.WriteLine("{1} {2} {0}", numberOne, numberTwo, numberThree);
                }
                else
                {
                    Console.WriteLine("{2} {1} {0}", numberOne, numberTwo, numberThree);
                }

            }
        }
    }
}

