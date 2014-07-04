namespace SurfaceCalculations
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(float h, float w)
            : base(h, w)
        {
        }

        public override float CalculateSurface()
        {
            // the only logical usage of widht and height. Here the surface is width * height
            return this.Height * this.Width;
        }
    }
}
