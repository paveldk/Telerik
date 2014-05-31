namespace School
{
    using System;

    public class Disciplines
    {
        private const string DefaultComment = "";

        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Disciplines(string name, int lectures, int exercises, string dcomment = DefaultComment)
        {
            this.DisciplineName = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
            this.Comment = dcomment;
        }

        // I'm gonna set DisciplineName with private Set, so noone to be able to change the name from outside
        public string DisciplineName
        {
            get
            {
                return this.disciplineName;
            }

            private set
            {
                if (value == string.Empty)
                {
                    Console.WriteLine("Name can't be empty string, please input something!");
                }
                else
                {
                    this.disciplineName = value;
                }              
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures; 
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Number of lectures can't be negative!");
                }
                else
                {
                    this.numberOfLectures = value;
                }              
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises; 
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Number of exercises can't be negative!");
                }
                else
                {
                    this.numberOfExercises = value;
                }              
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
    }
}
