using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Input the value for side a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Input the value for side b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Input the height: ");
        float h = float.Parse(Console.ReadLine());

        Console.WriteLine("The trapezoid area is " + ((float)a+b)/2*h );
        
    }
}
