namespace _3D
{
    using System;
    using System.Text;

    public struct Point3D
    {
        /* According to Style cop static readonly fields must start with Uppercase but 
         * JustCode "thinks" that they must start with lower, so I left lower
         * */
        private static readonly Point3D coordinateSystemStart = new Point3D(0, 0, 0);
        private double x;
        private double y;
        private double z;

        public Point3D(double pointX, double pointY, double pointZ)
            : this()
        {
            // we need only 1 constructor with all three properties, becouse 3D point needs X and Y and Z
            this.X = pointX;
            this.Y = pointY;
            this.Z = pointZ;
        }

        public static Point3D CoordinateSystemStart
        {
            get
            {
                // we can't set it - it's readonly field so we need just get, to call it if we need it
                return coordinateSystemStart;
            }
        }

        public double X
        {
            get
            {
                return this.x;
            }

            set
            {
                // for all the three we can set some restrictions or try except statement, but for Homework it's not necessary
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }

            set
            {
                this.z = value;
            }
        }

        public override string ToString()
        {
            // just print on the line x y and z separated by ","
            StringBuilder result = new StringBuilder();
            result.Append(this.X + ", ");
            result.Append(this.Y + ", ");
            result.Append(string.Empty + this.Z);

            return result.ToString();
        }
    }
}
