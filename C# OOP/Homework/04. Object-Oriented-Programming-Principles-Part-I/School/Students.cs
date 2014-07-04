namespace School
{
    using System;

    public class Students : People
    {
        private string uniqueClassNumber;

        public Students(string sname, string scomment, string snumber) 
            : base(sname, scomment)
        {
            this.UniqueClassNumber = snumber;
        }

        // Private set becouse the number should be set only in constructor, students can't change their student number
        public string UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }

            private set
            {
                if (value == string.Empty)
                {
                    Console.WriteLine("The unique number can't be empty string, please input something!");
                }
                else
                {
                    this.uniqueClassNumber = value;
                }                 
            }
        }
    }
}
