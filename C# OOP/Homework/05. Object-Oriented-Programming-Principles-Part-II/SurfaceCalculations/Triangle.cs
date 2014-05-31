namespace SurfaceCalculations
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(float h, float w) : base(h, w)
        {
        }

        public override float CalculateSurface()
        {
            // Triangle formula is (a * ha) / 2, for ha we're using width, for a Height, could be contrariwise :)
            return (this.Height * this.Width) / 2;
        }
    }
}
