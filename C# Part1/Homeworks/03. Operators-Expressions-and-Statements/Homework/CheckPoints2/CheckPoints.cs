using System;

class CheckPoint
{
    static void Main()
    {
        Console.Write("Input radius of the circle(Center 1:1): ");
        float Radius = float.Parse(Console.ReadLine());
        Console.Write("Input height of the rectangle(top 1, left -1): ");
        float Height = float.Parse(Console.ReadLine());
        Console.Write("Input width of the rectangle(top 1, left -1): ");
        float Width = float.Parse(Console.ReadLine());
        Console.Write("Input x: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Input y: ");
        float y = float.Parse(Console.ReadLine());

        if ((Math.Pow(x, 2)) + (Math.Pow(y, 2)) < 9)
        {
            if (x<-1 || x>Width || y<1 || y>Height)  
            {
                Console.WriteLine("The point is in the circle and out of the rectangle");
            }
            else
            {
                Console.WriteLine("The point is in the circle but in the rectangle too"); 
            }
            
        }
        else
        {
            Console.WriteLine("The point isn't in the circle at all!"); 
        }


    }
}
