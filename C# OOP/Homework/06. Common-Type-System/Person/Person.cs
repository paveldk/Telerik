namespace Person
{
    using System;

    public class Person
    {
        // Gonna set the age to null as default, if someone set it it gonna take user's value
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        // setting to int? we allow having null as value
        public int? Age { get; set; }

        public override string ToString()
        {
            // if age is set, gonna print it, otherwise - unspecified
            if (this.Age != null)
            {
                return this.Name + ", " + this.Age;
            }
            else
            {
                return this.Name + ", Age - unspecified";              
            }
        }
    }
}
