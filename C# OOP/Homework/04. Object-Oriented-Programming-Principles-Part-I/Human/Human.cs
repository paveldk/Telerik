namespace Human
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string name, string family)
        {
            this.FirstName = name;
            this.LastName = family;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == string.Empty)
                {
                    Console.WriteLine("Please input first name!");
                }
                else
                {
                    this.firstName = value;
                }            
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == string.Empty)
                {
                    Console.WriteLine("Please input last name!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
    }
}
