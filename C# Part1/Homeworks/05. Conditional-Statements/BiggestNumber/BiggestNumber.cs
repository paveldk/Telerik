using System;

class BiggestNumber
{
    static void Main()
    {
        // Write a program that finds the biggest of three integers using nested if statement

        Console.Write("Input number one: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Input number two: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Input number three: ");
        int numberThree = int.Parse(Console.ReadLine());


        if (numberOne > numberTwo)
        {
            if (numberOne > numberThree)
            {
                Console.WriteLine("Biggest number is: {0}", numberOne);    
            }
            else
            {
                Console.WriteLine("Biggest number is: {0}", numberThree);  
            }
        }
        else
        {
            if (numberTwo > numberThree)
            {
                Console.WriteLine("Biggest number is: {0}", numberTwo);
            }
            else
            {
                Console.WriteLine("Biggest number is: {0}", numberThree);
            }
        }

    }
}

