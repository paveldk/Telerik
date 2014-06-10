using System;
using System.Collections.Generic;

public class Course
{
    private string name;
    private ICollection<Student> students = new List<Student>();

    public Course(string courseName)
    {
        this.Name = courseName;
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

    public ICollection<Student> Students
    {
        get
        {
            return this.students;
        }
    }

    public void AddStudent(Student student)
    {
        if (!this.students.Contains(student))
        {
            if (this.students.Count < 30)
            {
                this.students.Add(student);
            }
            else
            {
                throw new ArgumentException("The course is full and cannot be signed!");
            }
        }
        else
        {
            throw new ArgumentException("Student is already signed this course");
        }   
    }

    public void RemoveStudent(Student student)
    {
        if (this.students.Contains(student))
        {
            this.students.Remove(student);
        }
        else
        {
            throw new ArgumentException("Student is not signed this course");
        }
    }
}