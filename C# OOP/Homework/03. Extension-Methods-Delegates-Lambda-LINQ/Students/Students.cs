namespace StudentsAgain
{
    using System.Collections.Generic;
    using System.Text;

    class Students
    {
        // again only Class with preporties, not checking for right entries, only override to ToString
        public Students(string stName, string stFamily, string stFn, string stTel, string stEmail, int stGroupNumber, List<int> stMarks)
        {
            this.FirstName = stName;
            this.LastName = stFamily;
            this.Fn = stFn;
            this.Tel = stTel;
            this.Email = stEmail;
            this.GroupNumber = stGroupNumber;
            this.Marks = stMarks;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Fn { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public int GroupNumber { get; set; }

        public List<int> Marks { get; set; }

        public override string ToString()
        {
            // need to override ToString if we wanna actually see the details
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.FirstName + " " + this.LastName + ", F number: " + this.Fn);
            result.AppendLine("Phone: " + this.Tel);
            result.AppendLine("Email: " + this.Email);
            result.AppendLine("Group: " + this.GroupNumber);

            string marks = string.Empty;
            foreach (var item in this.Marks)
            {
                marks = marks + item + ",";    
            }

            marks = marks.TrimEnd(',');

            result.AppendLine("Marks: " + marks);

            return result.ToString();
        }
    }
}
