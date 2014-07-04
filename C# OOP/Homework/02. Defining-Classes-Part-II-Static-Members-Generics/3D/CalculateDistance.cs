namespace _3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class CalculateDistance
    {
        public static double Distance(Point3D startPoint, Point3D endPoint)
        {
            double distance;

            double xDiff = startPoint.X - endPoint.X;
            double yDiff = startPoint.Y - endPoint.Y;
            double zDiff = startPoint.Z - endPoint.Z;

            // Math equation of calculating distance between 3D points
            distance = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2) + Math.Pow(zDiff, 2));

            return distance;
        }
    }
}
