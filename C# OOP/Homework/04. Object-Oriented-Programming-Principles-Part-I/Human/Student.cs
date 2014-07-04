namespace Human
{
    using System;

    public class Student : Human
    {
        private float grade;

        public Student(string sname, string sfamily, float sGrade)
            : base(sname, sfamily)
        {
            this.Grade = sGrade;
        }

        public float Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value <= 1 || value > 6)
                {
                    Console.WriteLine("Grades must be between 2 and 6!");
                }
                else
                {
                    this.grade = value;
                }
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Grade;
        }
    }
}