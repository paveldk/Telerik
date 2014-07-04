using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Input width:");
        int Width = int.Parse(Console.ReadLine());
        Console.Write("Input height:");
        int Height = int.Parse(Console.ReadLine());
        Console.WriteLine("The area is "+Width*Height);
    }
}
