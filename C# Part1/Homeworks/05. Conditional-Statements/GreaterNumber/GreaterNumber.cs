using System;

class GreaterNumber
{
    static void Main()
    {
        // Write an if statement that examines two integer variables and exchange their values if the first number is greater than the second one
        Console.Write("Input number one: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Input number two: ");
        int numberTwo = int.Parse(Console.ReadLine());
        int tempNumber;

        if (numberOne>numberTwo)
        {
            tempNumber = numberOne;
            numberOne = numberTwo;
            numberTwo = tempNumber;
            Console.WriteLine("Exchanging...");
        }

        Console.WriteLine("Number one is {0} and number two is {1}", numberOne, numberTwo);
    }
}

