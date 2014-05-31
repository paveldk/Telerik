namespace _3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        public static void SaveToFile(Path points)
        {
            // for saving all we need is write every single point in the SequenceOfPoints
            string fileName = @"..\..\path3D.txt";
            StreamWriter writer = new StreamWriter(fileName);

            using (writer)
            {
                foreach (var point in points.SequenceOfPoints)
                {
                    writer.WriteLine(point);    
                }                
            }
        }

        public static Path LoadFromFile()
        {
            /* for load we need to read the file line by line, separate numers from "," 
             * and get first one for X, second for Y and third for Z. We can be sure that 
             * they gonna be 3 everytime if they was saved using the Save method. We can add
             * try except method if someone mess with the file, but for the homework it's not
             * necessary
             * */
            string fileName = @"..\..\path3D.txt";
            StreamReader reader = new StreamReader(fileName);
            Path listOfPoints = new Path();
            Point3D point = new Point3D();

            string line = reader.ReadLine();

            using (reader)
            {
                while (line != null)
                {
                    string[] coordinates = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    point.X = Convert.ToDouble(coordinates[0]);
                    point.Y = Convert.ToDouble(coordinates[1]);
                    point.Z = Convert.ToDouble(coordinates[2]);

                    listOfPoints.AddPoint(point);
                   
                    line = reader.ReadLine();
                }
            }

            return listOfPoints;
        }
    }
}