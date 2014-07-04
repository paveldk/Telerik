namespace School
{
    using System;

    public abstract class People
    {
        private const string DefaultComment = "";

        private string name;
        private string comment;

        public People(string pname, string pcomment = DefaultComment)
        {
            this.Name = pname;
            this.Comment = pcomment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == string.Empty)
                {
                    Console.WriteLine("Name can't be empty string, please input something!");
                }
                else
                {
                    this.name = value;
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
