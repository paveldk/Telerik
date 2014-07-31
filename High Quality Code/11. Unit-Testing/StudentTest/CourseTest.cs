namespace StudentTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestToAddCourseWithNullName()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToAddCourseWithEmptyName()
        {
            Course course = new Course(string.Empty);
        }

        [TestMethod]
        public void TestToGetTheNameOfCourse()
        {
            Course course = new Course("test");
            string courseName = course.Name;

            Assert.AreEqual("test", courseName, "When we get name of this course it should be Test, at least for this example");
        }

        [TestMethod]
        public void TestToAddStudentInCourse()
        {
            Course course = new Course("TestCourse");
            Student student = new Student("Pesho", 11111);
            
            student.JoinCourse(course);

            Assert.AreEqual(1, course.Students.Count, "When we add first student the count in course student list should be 1");
        }

        [TestMethod]
        public void TestToAddTwoStudentInCourse()
        {
            Course course = new Course("TestCourse");
            Student student = new Student("Pesho", 11111);
            Student secondStudent = new Student("Gosho", 11112);

            student.JoinCourse(course);
            secondStudent.JoinCourse(course);

            Assert.AreEqual(2, course.Students.Count, "When we add two student the count in course student list should be 2");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToAddStudentInCourseTwice()
        {
            Course course = new Course("TesCourse");
            Student student = new Student("Pesho", 11111);
            student.JoinCourse(course);
            student.JoinCourse(course);
        }

        [TestMethod]
        public void TestToRemoveStudentFromCourse()
        {
            Course course = new Course("TestCourse");
            Student student = new Student("Pesho", 11111);

            student.JoinCourse(course);
            student.LeaveCourse(course);

            Assert.AreEqual(0, course.Students.Count, "When we add first student and then he leave the course the count in course student list should be 0");      
        }

        [TestMethod]
        public void TestToAddTwoStudentsInCourseAndRemoveOneOfThem()
        {
            Course course = new Course("TestCourse");
            Student student = new Student("Pesho", 11111);
            Student secondStudent = new Student("Gosho", 11112);

            student.JoinCourse(course);
            secondStudent.JoinCourse(course);
            student.LeaveCourse(course);

            Assert.AreEqual(1, course.Students.Count, "When we add two students and first student leave the course the count in course student list should be 1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentToLeaveACourseWhichHeDidntSigned()
        {
            Course course = new Course("TestCourse");
            Student student = new Student("Pesho", 11111);

            student.LeaveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToAddMoreThan30StudentsInCourse()
        {
            Course course = new Course("TestCourse");

            for (int i = 0; i < 31; i++)
            {
                course.AddStudent(new Student("Gosho", i + 10000)); 
            }
        }
    }
}
