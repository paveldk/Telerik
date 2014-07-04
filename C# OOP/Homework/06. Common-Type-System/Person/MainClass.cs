/* Create a class Person with two fields – name and age. Age can be left unspecified 
 * (may contain null value. Override ToString() to display the information of a person 
 * and if age is not specified – to say so. Write a program to test this functionality.
 * */
namespace Person
{
    using System;

    class MainClass
    {
        static void Main()
        {
            // one person without age
            Person someone = new Person("Pesho");
            Console.WriteLine(someone);

            // and one with age
            Person someoneWithAge = new Person("Gosho", 35);
            Console.WriteLine(someoneWithAge);

            // we gonna set the age to the first one and see the difference
            someone.Age = 18;
            Console.WriteLine(someone);
        }
    }
}
