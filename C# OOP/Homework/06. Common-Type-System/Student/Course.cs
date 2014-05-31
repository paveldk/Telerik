namespace Student
{
    using System;

    public class Course : ICloneable
    {     
        public Course()
        {

        }

        public Course(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        public object Clone()
        {
            // Name is string so can be transfered directly

            Course newCourse = new Course();
            newCourse.Name = this.Name;

            return newCourse;
        }
    }
}
