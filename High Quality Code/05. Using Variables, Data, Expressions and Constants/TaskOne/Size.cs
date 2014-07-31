// Refactor the following code to use proper variable naming and simplified expressions:
namespace TaskOne
{
    using System;
    using System.Linq;

    public class Size
    {
        private double width = 0; 
        private double height = 0;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angle)
        {
            double widthCos = Math.Abs(Math.Cos(angle)) * size.width;
            double heightCos = Math.Abs(Math.Cos(angle)) * size.height;
            double widthSin = Math.Abs(Math.Sin(angle)) * size.width;
            double heightSin = Math.Abs(Math.Sin(angle)) * size.height;

            double newSizeWidth = widthCos + widthSin;
            double newSizeHeight = heightCos + heightSin;

            return new Size(newSizeWidth, newSizeHeight);
        }
    }
}