using System;

class SignOfProduct
{
    static void Main()
    {
        // Write a program that shows the sign of a product of three real numbers without calculating it. Use a sequence of if statements.

        Console.Write("Input number one: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.Write("Input number two: ");
        float numberTwo = float.Parse(Console.ReadLine());
        Console.Write("Input number three: ");
        float numberThree = float.Parse(Console.ReadLine());

        //If any of the numbers is 0 the product is 0.
        if ((numberOne == 0) || (numberTwo==0) || (numberThree == 0))
        {
            Console.WriteLine("0");
        }
        else if (numberOne > 0)       
        {
            if (numberTwo>0)
            {
                if (numberThree>0)
                {
                    //If all of the numbers are positive then the sign is +
                    Console.WriteLine("+");
                }
                else
                {
                    //First two are positive but last is negative, sign -
                    Console.WriteLine("-");
                }
            }
            else
            {
                if (numberThree > 0)
                {
                    //First and third are positive but second is negative, sign -
                    Console.WriteLine("-");
                }
                else
                {
                    //First is positive and second and third are negative, sign +
                    Console.WriteLine("+");
                }
            }
        }
        else
        {
            if (numberTwo>0)
            {
                if (numberThree>0)
                {
                    //Number two and three are positive but one is negative, sign -
                    Console.WriteLine("-");
                }
                else
                {
                    //Number two is positive and one and three are negative, sign +
                    Console.WriteLine("+");
                }

            }
            else
            {
                if (numberThree > 0)
                {
                    //Number one and two are negative and three is positive, sign +
                    Console.WriteLine("+");
                }
                else
                {
                    //All is negative
                    Console.WriteLine("-");
                }
            }
        }
    }
}

