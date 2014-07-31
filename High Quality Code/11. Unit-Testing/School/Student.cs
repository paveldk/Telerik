using System;
using System.Collections.Generic;

public class Student
{
    private string name;
    private int uniqueNumber;

    public Student(string studentName, int studentUniqueNumber)
    {
        this.Name = studentName;
        this.UniqueNumber = studentUniqueNumber;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("NULL names are not allowed!");
            }

            if (value == string.Empty)
            {
                throw new ArgumentException("Name can not be empty!");
            }

            this.name = value;
        }
    }

    public int UniqueNumber
    {
        get
        {
            return this.uniqueNumber;
        }

        private set
        {
            if (value < 10000 || value > 99999)
            {
                throw new ArgumentException("UniqueNumber must be between 10000 and 99999");
            }

            this.uniqueNumber = value;
        }
    }

    public void JoinCourse(Course course)
    {
        course.AddStudent(this);      
    }

    public void LeaveCourse(Course course)
    {
        course.RemoveStudent(this);
    }
}
