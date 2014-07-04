namespace SurfaceCalculations
{
    public abstract class Shape
    {
        // Two constructors one for the radius(only 1 variable)
        protected Shape(float w)
        {
            this.Width = w;
        }

        // The other for rectangle and triangle. The constructos are protected.
        protected Shape(float h, float w)
            : this(w)
        {
            this.Height = h;
        }

        public float Width { get; set; }

        public float Height { get; set; }

        // and the abstract method
        public abstract float CalculateSurface();
    }
}
