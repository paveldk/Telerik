namespace SurfaceCalculations
{
    using System;

    public class Circle : Shape
    {
        // here we're using the version of constructor with only 1 variable, we need only radius
        public Circle(float radius)
            : base(radius)
        {
            this.Width = radius;
        }

        public override float CalculateSurface()
        {
            // the Surface is Pi * R * R, so this is the formula
            return (float)(Math.PI * Math.Pow(this.Width, 2));
        }
    }
}
