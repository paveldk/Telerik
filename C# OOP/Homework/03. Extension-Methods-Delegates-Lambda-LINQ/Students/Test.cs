namespace StudentsAgain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            List<Students> students = new List<Students>();

            students.Add(new Students("Ivan", "Ivanov", "150870608", "028123456", "iivanov@abv.bg", 1, new List<int>() { 5, 5, 6, 6 }));
            students.Add(new Students("Ivan", "Petrov", "187650709", "0348123456", "ipetrov@gmail.com", 2, new List<int>() { 4, 3, 3, 2 }));
            students.Add(new Students("Vladimir", "Draganov", "237850608", "025123456", "vdraganov@abv.bg", 2, new List<int>() { 5, 4, 3, 6 }));
            students.Add(new Students("Simeon", "Angelov", "348750807", "0329123456", "sangelov@mail.bg", 1, new List<int>() { 6, 3, 6, 6 }));
            students.Add(new Students("Dobromir", "Slabakov", "019820689", "0329123456", "dslabakov@mail.bg", 2, new List<int>() { 2, 2 }));

            /* Task 9 Select only the students that are from group number 2. Use LINQ query.
             *  Order the students by FirstName.*
             *  */
            StudentSecondGroupOrderedLINQ(students);            
            Console.WriteLine(new string('-', Console.WindowWidth));

            /* Task 10 Implement the previous using the same query expressed with extension 
             * methods. 
             *  */
            StudentSecondGroupOrderedLambda(students);
            Console.WriteLine(new string('-', Console.WindowWidth));
            
            /* Task 11 Extract all students that have email in abv.bg. Use string methods 
             * and LINQ.
             * */
            StudentsWithMailInABV(students);
            Console.WriteLine(new string('-', Console.WindowWidth));

            /* Task 12 Extract all students with phones in Sofia. Use LINQ.*/
            StudentsWithPhonesInSofia(students);
            Console.WriteLine(new string('-', Console.WindowWidth));

            /* Task 13 Select all students that have at least one mark Excellent (6) 
             * into a new anonymous class that has properties – FullName and Marks. 
             * Use LINQ
             * */
            StudentsWithAtLeastOneExcelentMark(students);
            Console.WriteLine(new string('-', Console.WindowWidth));

            /* Task 14 Write down a similar program that extracts the students with exactly  
             * two marks "2". Use extension methods.
             * */
            StudentsWithExactlyTwoMarks2(students);
            Console.WriteLine(new string('-', Console.WindowWidth));

            /* Task 15 Extract all Marks of the students that enrolled in 2006. (The students from 
             * 2006 have 06 as their 5-th and 6-th digit in the FN).
             * */
            StudentsEnrolled2006(students);
            Console.WriteLine(new string('-', Console.WindowWidth));

            /* Task 18 Create a program that extracts all students grouped by GroupName and 
             * then prints them to the console. Use LINQ.
             * */
            AllStudentsGroupedByGroup(students);
            Console.WriteLine(new string('-', Console.WindowWidth));

            // Rewrite the previous using extension methods.
            AllStudentsGroupedByGroupLambda(students);
            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        private static void AllStudentsGroupedByGroupLambda(List<Students> students)
        {
            Console.WriteLine("Students grouped by groupnumber Lambda");

            /* using groupBy by selected property and then printing the results. We're sorting
             * them, so the groups to be in proper order displayed
             * */

            var sortedStudents = students.GroupBy(x => x.GroupNumber).OrderBy(x => x.Key);

            foreach (var currentGroup in sortedStudents)
            {
                Console.WriteLine(currentGroup.Key);

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }

                Console.WriteLine();
            }
        }

        private static void AllStudentsGroupedByGroup(List<Students> students)
        {
            Console.WriteLine("Students grouped by groupnumber LINQ");

            // same like the one up, but with LINQ logic, again ordered by the Key
            var sortedStudents =
                from student in students
                group student by student.GroupNumber into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var currentGroup in sortedStudents)
            {
                Console.WriteLine(currentGroup.Key);

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }

                Console.WriteLine();
            }
        }

        private static void StudentsEnrolled2006(List<Students> students)
        {
            Console.WriteLine("All marks of the students enrolled in 2006");

            /* we know that students enrolled in 2006 have 5 and 6 digits 06, so we search 
             * for substring equal to 06 starting on position 5 and long 2 elements
             * */
            var sortedStudents =
                from student in students
                where student.Fn.Substring(5, 2) == "06"
                select student;

            foreach (Students st in sortedStudents)
            {
                string marks = string.Empty;
                foreach (var item in st.Marks)
                {
                    marks = marks + item + ',';
                }

                marks = marks.TrimEnd(',');
                Console.WriteLine(marks);
            }
        }

        private static void StudentsWithExactlyTwoMarks2(List<Students> students)
        {
            Console.WriteLine("Student with at exactly two weak marks(2)");

            // if the count of marks 2 is exactly 2 we create new anonymous class and then print it
            var sortedStudents = students.Where(st => st.Marks.Count(m => m == 2) == 2)
                .Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks });

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FullName);

                string marks = string.Empty;
                foreach (var item in student.Marks)
                {
                    marks = marks + item + ',';
                }

                marks = marks.TrimEnd(',');

                Console.WriteLine(marks);
            }
        }

        private static void StudentsWithAtLeastOneExcelentMark(List<Students> students)
        {
            Console.WriteLine("Student with at least one excelent mark");

            // Marks is list and list have Contains, we check if Contains 6, if so put it into the anonymous class then print it
            var sortedStudents =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FullName);

                string marks = string.Empty;
                foreach (var item in student.Marks)
                {
                    marks = marks + item + ',';   
                }

                marks = marks.TrimEnd(',');

                Console.WriteLine(marks);
            }
        }

        private static void StudentsWithPhonesInSofia(List<Students> students)
        {
            Console.WriteLine("Student with phones in Sofia");

            /* If from Sofia, the phone have to start with 02, at least in my system :)
             * Here all students are from Bulgaria, so every number start with local code
             * without 359 :)
             * */
            var sortedStudents =
                from student in students
                where student.Tel.StartsWith("02")
                select student;

            foreach (Students st in sortedStudents)
            {
                Console.WriteLine(st);
            }
        }

        private static void StudentSecondGroupOrderedLINQ(List<Students> students)
        {
            Console.WriteLine("Student grom group 2, sorted by Name LINQ");

            // just check if GroupNumber is equal to 2
            var sortedStudents =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (Students st in sortedStudents)
            {
                Console.WriteLine(st);
            }
        }

        private static void StudentSecondGroupOrderedLambda(List<Students> students)
        {
            Console.WriteLine("Student grom group 2, sorted by Name Lambda");

            // same here
            var sortedStudents = students.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            foreach (Students st in sortedStudents)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
        }

        private static void StudentsWithMailInABV(List<Students> students)
        {
            Console.WriteLine("Student with emails in abv.bg");

            // emails from abv.bg gonna end with abv.bg :) we're using that
            var sortedStudents =
                from student in students
                where student.Email.EndsWith("abv.bg")
                select student;

            foreach (Students st in sortedStudents)
            {
                Console.WriteLine(st);
            }
        }
    }
}
