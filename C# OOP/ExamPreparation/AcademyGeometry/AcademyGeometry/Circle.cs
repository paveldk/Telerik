namespace GeometryAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Circle : Figure, IAreaMeasurable, IFlat
    {
        protected Vector3D Center
        {
            get { return this.vertices[0]; }
            set { this.vertices[0] = value; }
        }

        protected float Radius { get; set; }

        public Circle(Vector3D center, float radius) : base(center)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
            return Math.Abs(Math.Pow(Radius, 2) * Math.PI);
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetArea();
        }

        public Vector3D GetNormal()
        {
            Vector3D center = this.GetCenter();
            Vector3D A = new Vector3D(center.X + this.Radius, center.Y, center.Z),
                B = new Vector3D(center.X, center.Y + this.Radius, center.Z);

            Vector3D normal = Vector3D.CrossProduct(center - A, center - B);
            normal.Normalize();
            return normal;
        }
    }
}
