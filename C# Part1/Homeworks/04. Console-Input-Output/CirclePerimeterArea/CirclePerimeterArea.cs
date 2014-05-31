using System;

class CirclePerimeterArea
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area.

        Console.Write("Input the radius: ");
        int r = int.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(r, 2);
        double perimeter = Math.PI * r * 2;
        Console.WriteLine("The area of the circle with radius {0} is {1:F2} and it's perimeter is {2:F2}.", r, area, perimeter);
    }
}
