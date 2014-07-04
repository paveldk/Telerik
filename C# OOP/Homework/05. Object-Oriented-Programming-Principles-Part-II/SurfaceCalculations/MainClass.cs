/* Define abstract class Shape with only one abstract method CalculateSurface() and fields 
 * width and height. Define two new classes Triangle and Rectangle that implement the 
 * virtual method and return the surface of the figure (height*width for rectangle and 
 * height*width/2 for triangle). Define class Circle and suitable constructor so that at 
 * initialization height must be kept equal to width and implement the CalculateSurface() 
 * method. Write a program that tests the behavior of  the CalculateSurface() method for 
 * different shapes (Circle, Rectangle, Triangle) stored in an array.
 * */

namespace SurfaceCalculations
{
    using System;
    using System.Collections.Generic;

    class MainClass
    {
        static void Main()
        {
            // We make a list of shapes
            List<Shape> shapes = new List<Shape>();

            // then add different shapes, using both constructors
            shapes.Add(new Circle(10));
            shapes.Add(new Rectangle(10, 8));
            shapes.Add(new Triangle(8, 7));

            // and print the result from each method
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface()); 
            }
        }
    }
}
