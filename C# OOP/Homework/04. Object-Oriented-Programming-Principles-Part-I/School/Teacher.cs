namespace School
{
    using System.Collections.Generic;

    public class Teacher : People
    {
        private List<Disciplines> courses;

        // One constructor only with name, if Teacher has no courses yet
        public Teacher(string tname, string tcomment)
            : base(tname, tcomment)
        { 
        }

        // and one with set of courses
        public Teacher(string tname, string tcomment, List<Disciplines> tcourses)
            : base(tname, tcomment)
        {
            this.Courses = tcourses;
        }

        public List<Disciplines> Courses
        {
            get
            {
                return this.courses;
            }

            private set
            {
                this.courses = value;
            }
        }

        public void AddCourse(Disciplines newCourse)
        {
            this.Courses.Add(newCourse);
        }

        public void RemoveCourse(Disciplines oldCourse)
        {
            this.Courses.Remove(oldCourse);
        }
    }
}
