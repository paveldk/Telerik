namespace _3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path
    {
        private List<Point3D> sequenceOfPoints;

        public Path()
        {
            this.sequenceOfPoints = new List<Point3D>();        
        }

        public List<Point3D> SequenceOfPoints
        {
            get
            {
                return this.sequenceOfPoints;
            }

            private set
            {
                // we can set here some restrictions, for the purpose of the Homework it's not necessary
                this.sequenceOfPoints = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            // using this for adding points, if in loop we can add as many as we want
            this.SequenceOfPoints.Add(point);
        }

        public void ClearList()
        {
            // for clearing the List
            this.SequenceOfPoints.Clear();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            int index = 0;
            foreach (var point in this.SequenceOfPoints)
            {
                result.AppendLine("X[" + index + "] : " + point.X);
                result.AppendLine("Y[" + index + "] : " + point.Y);
                result.AppendLine("Z[" + index + "] : " + point.Z);
                index++;
            }

            return result.ToString();
        }
    }
}
