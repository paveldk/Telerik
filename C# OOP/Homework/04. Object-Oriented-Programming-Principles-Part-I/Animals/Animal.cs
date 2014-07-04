namespace Animals
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal
    {
        private string name;
        private int age;
        private string sex;

        public Animal(string aName, int aAge, string aSex)
        {
            this.Name = aName;
            this.Age = aAge;
            this.Sex = aSex;
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
                    Console.WriteLine("Name can't be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age can't be negative");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
                if (value != "male" && value != "female")
                {
                    Console.WriteLine("Sex can be only male or female");
                }
                else
                {
                    this.sex = value;
                }
            }
        }
    }
}
