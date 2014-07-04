namespace School
{
    using System;
    using System.Collections.Generic;

    public class Classes
    {
        private const string DefaultComment = "";

        private string uniqueTextIdentifier;
        private List<Teacher> classTeachers;
        private List<Students> classStudents;
        private string comment;

        // two constructors, one only with Id, we can add Student and Courses later
        public Classes(string id, string cComment = DefaultComment)
        {
            this.UniqueTextIdentifier = id;
            this.Comment = cComment;
        }

        // and one with all set
        public Classes(string id, string cComment, List<Teacher> teachers, List<Students> students) 
            : this(id, cComment)
        {           
            this.ClassTeachers = teachers;
            this.ClassStudents = students;
        }
        
        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }

            private set
            {
                if (value == string.Empty)
                {
                    Console.WriteLine("Name can't be empty string, please input something!");
                }
                else
                {
                    this.uniqueTextIdentifier = value;
                }               
            }
        }

        public List<Teacher> ClassTeachers
        {
            get
            {
                return this.classTeachers;
            }

            private set
            {
                this.classTeachers = value;
            }
        }

        public List<Students> ClassStudents
        {
            get
            {
                return this.classStudents;
            }

            private set
            {
                this.classStudents = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }

        // a set of methods to add or remove Students and Teachers
        public void AddTeacher(Teacher newTeacher)
        {
            this.ClassTeachers.Add(newTeacher);
        }

        public void AddStudent(Students newStudent)
        {
            this.ClassStudents.Add(newStudent);
        }

        public void RemoveTeacher(Teacher oldTeacher)
        {
            this.ClassTeachers.Remove(oldTeacher);
        }

        public void RemoveStudents(Students oldStudent)
        {
            this.ClassStudents.Remove(oldStudent);
        }
    }
}
