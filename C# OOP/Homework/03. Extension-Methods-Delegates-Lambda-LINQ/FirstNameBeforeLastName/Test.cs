namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            List<Students> students = new List<Students>();

            students.Add(new Students("Ivan", "Ivanov", 17));
            students.Add(new Students("Ivan", "Petrov", 18));
            students.Add(new Students("Vladimir", "Draganov", 27));
            students.Add(new Students("Simeon", "Angelov", 20));

            /* Task 3 Write a method that from a given array of students finds all 
             * students whose first name is before its last name alphabetically. 
             * Use LINQ query operators.
             * */

            Console.WriteLine("Name before family");
            NameBeforeFamily(students);
            Console.WriteLine();

            /* Task 4 Write a LINQ query that finds the first name and last name of 
             * all students with age between 18 and 24.
             * */

            Console.WriteLine("All between 18 and 24");
            FindAllBetween18And24(students);
            Console.WriteLine();

            /* Task 5 Using the extension methods OrderBy() and ThenBy() with lambda 
             * expressions sort the students by first name and last name in 
             * descending order. Rewrite the same with LINQ
             * */

            Console.WriteLine("Sorted with Lambda");
            SortWithLambda(students);
            Console.WriteLine();

            Console.WriteLine("Sorted with LINQ");
            SortWithLINQ(students);
            Console.WriteLine();
        }

        private static void SortWithLINQ(List<Students> students)
        {
            // Linq expression using orderby
            var sortedStudents =
                from student in students
                orderby student.Name, student.Family 
                select student;

            foreach (Students st in sortedStudents)
            {
                Console.WriteLine(st);
            }              
        }

        private static void SortWithLambda(List<Students> students)
        {
            // Simply Lambda expression for Sort
            var sortedStudents = students.OrderBy(st => st.Name).ThenBy(st => st.Family);

            foreach (Students st in sortedStudents)
            {
                Console.WriteLine(st);
            }               
        }

        private static void NameBeforeFamily(List<Students> students)
        {
            // we use compareTo string method saying if name is before family to BE IN the new List
            var nameBeforeFamily =
                from student in students
                where student.Name.CompareTo(student.Family) < 0
                select student;

            foreach (Students st in nameBeforeFamily)
            {
                Console.WriteLine(st);
            }               
        }

        private static void FindAllBetween18And24(List<Students> students)
        {
            // we use compareTo string method saying if name is before family to BE IN the new List
            var between18And24 =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (Students st in between18And24)
            {
                Console.WriteLine(st);
            }               
        }
    }
}
