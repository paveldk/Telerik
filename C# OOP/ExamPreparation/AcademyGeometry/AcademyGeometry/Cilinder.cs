namespace GeometryAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cilinder : Figure, IAreaMeasurable, IVolumeMeasurable
    {
        private Vector3D BottomCenter
        {
            get
            {
                return new Vector3D(this.vertices[0].X, this.vertices[0].Y, this.vertices[0].Z);
            }
            set
            {
                this.vertices[0] = new Vector3D(value.X, value.Y, value.Z);
            }
        }

        private Vector3D TopCenter
        {
            get
            {
                return new Vector3D(this.vertices[1].X, this.vertices[1].Y, this.vertices[1].Z);
            }
            set
            {
                this.vertices[1] = new Vector3D(value.X, value.Y, value.Z);
            }
        }

        private float Radius { get; set; }

        public Cilinder(Vector3D bottom, Vector3D top, float radius) : base(top, bottom)
        {
            this.BottomCenter = bottom;
            this.TopCenter = top;
            this.Radius = radius;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }     

        public double GetArea()
        {
            double baseArea = this.Radius * this.Radius * Math.PI;
            double topAndBottomArea = baseArea * 2;

            double basePerimeter = 2 * Math.PI * this.Radius;

            double sideArea = basePerimeter * (this.TopCenter - this.BottomCenter).Magnitude;

            return sideArea + topAndBottomArea;
        }

        public double GetVolume()
        {
            return this.Radius * this.Radius * Math.PI * (this.TopCenter - this.BottomCenter).Magnitude;

        }
    }
}
