namespace Abstraction
{
    using System;

    class FiguresExample
    {
        static void Main()
        {
            // Промених типа на circle и rect, за да се види, че полиморфизма си работи
            Figure circle = new Circle(5);
            Console.WriteLine("I am a circle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", circle.CalcPerimeter(), circle.CalcSurface());
            Figure rect = new Rectangle(2, 3);
            Console.WriteLine("I am a rectangle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", rect.CalcPerimeter(), rect.CalcSurface());
        }
    }
}
