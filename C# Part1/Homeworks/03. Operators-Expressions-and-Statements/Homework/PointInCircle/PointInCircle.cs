using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Input radius:");
        float Radius = float.Parse(Console.ReadLine());
        Console.Write("Input x:");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Input y:");
        float y = float.Parse(Console.ReadLine());

        if ((Math.Pow(x, 2))+(Math.Pow(y, 2))>25)
        {
            Console.WriteLine("The point isn't in the circle");  
        }
        else
        {
            Console.WriteLine("The point is in the circle");
        }

    }
}
