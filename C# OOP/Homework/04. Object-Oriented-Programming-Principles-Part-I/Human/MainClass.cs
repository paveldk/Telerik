/* Define abstract class Human with first name and last name. Define new class Student 
 * which is derived from Human and has new field – grade. Define class Worker derived 
 * from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
 * that returns money earned by hour by the worker. Define the proper constructors and 
 * properties for this hierarchy. Initialize a list of 10 students and sort them by grade 
 * in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 
 * workers and sort them by money per hour in descending order. Merge the lists and sort 
 * them by first name and last name.
 * */
namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainClass
    {
        static void Main()
        {
            // Students
            var students = new List<Student>();
            Student student;

            // Adding 10 students
            student = new Student("Ivan", "Petrov", 4);
            students.Add(student);

            student = new Student("Nadia", "Mihailova", 3);
            students.Add(student);

            student = new Student("Ognyan", "Petkov", 4.5f);
            students.Add(student);

            student = new Student("Jivka", "Milanova", 5);
            students.Add(student);

            student = new Student("Stoyka", "Kalinina", 5.25f);
            students.Add(student);

            student = new Student("Borisa", "Ivanova", 2);
            students.Add(student);

            student = new Student("Dorina", "Doinska", 3);
            students.Add(student);

            student = new Student("Iliya", "Ivanov", 6);
            students.Add(student);

            student = new Student("Vasil", "Vasilev", 5.75f);
            students.Add(student);

            student = new Student("Goran", "Petrov", 3.25f);
            students.Add(student);

            // Creating LINQ query with order by Grade
            var orderedStudent =
                from s in students
                orderby s.Grade
                select s;

            // and Print it
            Console.WriteLine("Students:");
            foreach (var s in orderedStudent)
            {
                Console.WriteLine(s);
            }

            // Workers
            var workers = new List<Worker>();
            Worker worker;

            // Adding 10 workers
            worker = new Worker("Milan", "Petrov", 670, 8);
            workers.Add(worker);

            worker = new Worker("Evgeni", "Burgov", 1100, 11);
            workers.Add(worker);

            worker = new Worker("Nadia", "Nikolaeva", 600, 7);
            workers.Add(worker);

            worker = new Worker("Sotir", "Sotirov", 800, 8);
            workers.Add(worker);

            worker = new Worker("Maria", "Micheva", 2000, 10);
            workers.Add(worker);

            worker = new Worker("Dian", "Gochev", 1400, 6);
            workers.Add(worker);

            worker = new Worker("Mihail", "Karaivanov", 320, 4);
            workers.Add(worker);

            worker = new Worker("Marusya", "Doncheva", 1100, 12);
            workers.Add(worker);

            worker = new Worker("Georgi", "Atanasov", 890, 10);
            workers.Add(worker);

            worker = new Worker("Martin", "Georgiev", 700, 5);
            workers.Add(worker);
            
            // Creating LINQ query with order by using the method MoneyPerHour desc
            var orderedWorkers =
                from w in workers
                orderby w.MoneyPerHour() descending
                select w;

            Console.WriteLine("Workers");
            foreach (var w in orderedWorkers)
            {
                Console.WriteLine(w);
            }

            // Creating new list of humans
            var humans = new List<Human>();

            // adding both list to it
            humans.AddRange(students);
            humans.AddRange(workers);

            // LINQ query with order by first and last name
            var orderedBoth =
                from h in humans
                orderby h.FirstName, h.LastName
                select h;

            // and print
            Console.WriteLine("Humans");
            foreach (var h in orderedBoth)
            {
                Console.WriteLine(h);
            }
        }
    }
}
