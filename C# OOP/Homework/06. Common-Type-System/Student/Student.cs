namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student()
        {

        }

        public Student(string name, string surname, string family, string ssn, string address, string mobile, string email, List<Course> courses, enumFaculties faculty, enumSpecialties specialty, enumUniversity university)
        {
            this.FirstName = name;
            this.MiddleName = surname;
            this.LastName = family;
            this.SSN = ssn;
            this.PernamentAddress = address;
            this.MobilePhone = mobile;
            this.EMail = email;
            this.Courses = courses;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string SSN { get; set; }

        public string PernamentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string EMail { get; set; }

        public List<Course> Courses { get; set; }

        public enumFaculties Faculty { get; set; }

        public enumSpecialties Specialty { get; set; }

        public enumUniversity University { get; set; }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (student == null)
            {
                throw new ArgumentException("Passed object is not Student");
            }

            // The social security number is uniqe identifier. If it's equal the students are same person.
            if (this.SSN == student.SSN)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            // that's gonna be pretty unique number
            return this.FirstName.GetHashCode()
                ^ this.MiddleName.GetHashCode()
                ^ this.LastName.GetHashCode()
                ^ this.SSN.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.FirstName);
            result.AppendLine(this.MiddleName);
            result.AppendLine(this.LastName);
            result.AppendLine(this.SSN);
            result.AppendLine(this.PernamentAddress);
            result.AppendLine(this.EMail);
            result.AppendLine(this.MobilePhone);
            result.AppendLine("Courses:");
            foreach (var course in this.Courses)
	        {
		        result.AppendLine(course.ToString());
	        }
            result.AppendLine(this.University.ToString());
            result.AppendLine(this.Faculty.ToString());
            result.AppendLine(this.Specialty.ToString());

            return result.ToString();
        }
        public static bool operator ==(Student first, Student second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !object.Equals(first, second);
        }

        public object Clone()
        {
            // In deep clone we must create new instance of the object. Primitive type can be transfered directly
            var newStudent = new Student();
            newStudent.FirstName = this.FirstName;
            newStudent.MiddleName = this.MiddleName;
            newStudent.LastName = this.LastName;
            newStudent.SSN = this.SSN;
            newStudent.PernamentAddress = this.PernamentAddress;
            newStudent.EMail = this.EMail;
            newStudent.MobilePhone = this.MobilePhone;
            newStudent.University = this.University;
            newStudent.Specialty = this.Specialty;
            newStudent.Faculty = this.Faculty;

            // but for reference types we must go recursive into the next class and so on, so we must implement clone there too
            List<Course> newCourses = new List<Course>();
            foreach (var course in this.Courses)
            {
                Course newCourse = (Course)course.Clone();
                newCourses.Add(newCourse);
            }

            newStudent.Courses = newCourses;
            return newStudent;
        }

        public int CompareTo(Student otherStudent)
        {
            // Compare first name with otherStudent first name, if equal then Middle, if so then last and if all names are equal compare SSN
            if (this.FirstName.CompareTo(otherStudent.FirstName) != 0)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }                
            else if (this.MiddleName.CompareTo(otherStudent.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }               
            else if (this.LastName.CompareTo(otherStudent.LastName) != 0)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }                
            else
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }
        }
    }
}
