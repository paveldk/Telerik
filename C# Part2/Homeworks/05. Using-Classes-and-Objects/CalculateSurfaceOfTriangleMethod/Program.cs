/* Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it; Three sides; Two sides and an angle between them. 
 * Use System.Math.
 * */

namespace CalculateSurfaceOfTriangleMethod
{
    using System;

    class Program
    {
        static void Main()
        {
            // First we gonna create menu, so the user to be able to choose an option
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Calculate by side and altitude");
                Console.WriteLine("2.Calculate by three sides");
                Console.WriteLine("3.Calculate by two sides and ancle between");
                Console.Write("Choose an option: ");
                option = int.Parse(Console.ReadLine());
            } 
            while (option < 1 || option > 3);

            // And then for each option we gonna create submenus with different variables
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Input side value: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.Write("Input altitude value: ");
                    double altitude = double.Parse(Console.ReadLine());
                    double area = CalculateBySideAndAltitude(side, altitude);
                    Console.WriteLine("The area is {0}", area);
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Input side 1 value: ");
                    double side1 = double.Parse(Console.ReadLine());
                    Console.Write("Input side 2 value: ");
                    double side2 = double.Parse(Console.ReadLine());
                    Console.Write("Input side 3 value: ");
                    double side3 = double.Parse(Console.ReadLine());
                    area = CalculateByThreeSides(side1, side2, side3);
                    Console.WriteLine("The area is {0}", area);
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Input side 1 value: ");
                    side1 = double.Parse(Console.ReadLine());
                    Console.Write("Input side 2 value: ");
                    side2 = double.Parse(Console.ReadLine());
                    Console.Write("Input angle between them value: ");
                    double angle = double.Parse(Console.ReadLine());
                    area = CalculateByTwoSidesAndAngle(side1, side2, angle);
                    Console.WriteLine("The area is {0}", area);
                    break;
                default:
                    break;
            }
        }

        static double CalculateBySideAndAltitude(double side, double altitude)
        {
            // This method is so simple that don't need using System.Math
            double area = (side * altitude) / 2;
            return area;
        }

        static double CalculateByThreeSides(double side1, double side2, double side3)
        {
            /* To calculate area using 3 sides we use formula where we get
             * half perimeter (sum of the three sides devide by 2) and then we calculate it by
             * sqrt of the half perimeter multiply by half perimeter - side A, then - side B
             * and then - side C(formula below). To calculate sqrt we use System.Math
             * */
            double halfPerimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
            return area;
        }

        static double CalculateByTwoSidesAndAngle(double side1, double side2, double angle)
        {
            /* In this case the area is ((side 1 * side 2) / 2) * sin (angle):
             * But becouse Math.Sin is using radians we must first convert angle from degrees to radians:
            */
            angle = Math.PI / 180 * angle;
            double area = ((side1 * side2) / 2) * Math.Sin(angle);
            return area;
        }
    }
}
