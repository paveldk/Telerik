// The task condition is in the file TaskCondition.docx
namespace _3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Path some3Dpoints = new Path();
            Point3D threeDimPointOne = new Point3D(5, 60, -10);
            Console.WriteLine("Point A: ");
            Console.WriteLine(threeDimPointOne.ToString()); 

            some3Dpoints.AddPoint(threeDimPointOne);

            Point3D threeDimPointTwo = new Point3D(5, 60, -12);
            Console.WriteLine("Point B: ");

            Console.WriteLine(threeDimPointTwo.ToString());
            double distance = CalculateDistance.Distance(threeDimPointOne, threeDimPointTwo);

            Console.WriteLine("Distance between them: " + distance);

            some3Dpoints.AddPoint(threeDimPointTwo);
            Console.WriteLine("And the two points in the list: "); 
            Console.WriteLine(some3Dpoints.ToString());

            Console.WriteLine("Let's Save the to text file and clear the list");

            PathStorage.SaveToFile(some3Dpoints);

            some3Dpoints.ClearList();
            Console.WriteLine("The points after the list was clear(nothing to see)");
            Console.WriteLine(some3Dpoints.ToString());

            Console.WriteLine("Now let's Load them back");

            some3Dpoints = PathStorage.LoadFromFile();

            Console.WriteLine("And to see the points again:");
            Console.WriteLine(some3Dpoints.ToString());
        }
    }
}
