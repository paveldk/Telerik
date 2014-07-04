namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainClass
    {
        static void Main()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course("Informatics"));
            Student pesho = new Student("Pesho", "Petrov", "Petrov", "12345", "Sofia", "0888123456", "pesho@telerik.com", courses , enumFaculties.Bachelor, enumSpecialties.Informatics, enumUniversity.NewBulgarianUniversity);

            Console.WriteLine(pesho);

            // We're creating a clone of our student
            Student peshoClone = (Student)pesho.Clone();

            // Adding some curses and changing the university of the original student
            courses.Add(new Course("C#"));
            pesho.Courses = courses;
            pesho.University = enumUniversity.TechnicalUniversity;

            // And we can see that the changes are only to the original, so the cloning is indeed deep
            Console.WriteLine(pesho);
            Console.WriteLine(peshoClone);

            if (pesho.CompareTo(peshoClone) == 0)
	        {
		        Console.WriteLine("Students are same person");
	        }
            else
            {
                Console.WriteLine("These are different students");
            }
        }
    }
}
