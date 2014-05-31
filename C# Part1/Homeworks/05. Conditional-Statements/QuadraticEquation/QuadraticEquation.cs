using System;

class quadraticEquation
{
    static void Main()
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

        int a = 0;

        // In quadratic equation a cannot be 0 so we must check if a is 0 and avoid it:
        do
        {
            Console.Write("Input a: ");
            a = int.Parse(Console.ReadLine());
        } while (a == 0);

        Console.Write("Input b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Input c: ");
        int c = int.Parse(Console.ReadLine());

        double solution1 = 0;

        double discriminant = Math.Pow(b, 2) - (4 * a * c);

        //When discriminant is <0 there is no solution.
        if (discriminant < 0)
        {
            Console.WriteLine("The equation has no solution!");
        }

        //When discriminant is 0 there is only 1 solution.
        if (discriminant == 0)
        {
            solution1 = -b / (2 * a);

            Console.WriteLine("The solutions is: {1}", solution1);
        }

        //When discriminant is >0 there are 2 solutions
        if (discriminant > 0)
        {
            solution1 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            double solution2 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            Console.WriteLine("The solutions are: {0} and {1}", solution1, solution2);
        }


    }
}
