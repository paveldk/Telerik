using System;
using System.Collections.Generic;

public class School
{
    private string name;
    private ICollection<Student> students = new List<Student>();
    private ICollection<int> numbers = new List<int>();

    public School(string name)
    {
        this.Name = name;
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

    public void AddStudent(Student student)
    {
        if (student == null)
        {
            throw new ArgumentException("NULL students are not allowed!");
        }

        if (this.numbers.Contains(student.UniqueNumber))
        {
            throw new ArgumentException("This uniqueNumber is already usd by another student!");
        }

        this.numbers.Add(student.UniqueNumber);

        this.students.Add(student);
    }
}
