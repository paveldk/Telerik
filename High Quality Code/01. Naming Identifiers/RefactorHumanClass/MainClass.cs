// Task 2 : Refactor the following examples to produce code with well-named identifiers in C#:
namespace RefactorHumanClass
{
    using System;
    using System.Linq;

    class MainClass
    {
        enum Gender 
        { 
            male, female 
        }

        public void MakePerson(int egnGenderNumber) // In bulgarian EGN penultimate number is about gender even - male, odd - female
        {
            Person newPerson = new Person();
            newPerson.Age = egnGenderNumber;
            if (egnGenderNumber % 2 == 0)
            {
                newPerson.Name = "Батката";
                newPerson.Gender = Gender.male;
            }
            else
            {
                newPerson.Name = "Мацето";
                newPerson.Gender = Gender.female;
            }
        }

        class Person
        {
            public Gender Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
