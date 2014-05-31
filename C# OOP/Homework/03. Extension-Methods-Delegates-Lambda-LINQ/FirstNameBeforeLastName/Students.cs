namespace Students
{
    class Students
    {
        // Just simple Class for the homework needs, no checking for anything and using only Properties
        public Students(string stName, string stFamily, int stAge)
        {
            this.Name = stName;
            this.Family = stFamily;
            this.Age = stAge;
        }

        public string Name { get; set; }

        public string Family { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            // need to override ToString if we wanna actually see the name and the family :)
            return this.Name + " " + this.Family;
        }
    }
}
