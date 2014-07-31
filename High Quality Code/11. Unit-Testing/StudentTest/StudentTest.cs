namespace StudentTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestToStudentWithNullName()
        {
            Student student = new Student(null, 23455);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToStudentWithEmptyName()
        {
            Student student = new Student(string.Empty, 23455);
        }

        [TestMethod]
        public void TestToGetTheNameOfStudent()
        {
            Student student = new Student("Pesho", 11111);
            string studentName = student.Name;

            Assert.AreEqual("Pesho", studentName, "When we get name of this student it should be Pesho, at least for this example");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToStudentWithSmallerwerUniqueNumberThenAllowed()
        {
            Student student = new Student("Pesho", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToStudentWithBiggerwerUniqueNumberThenAllowed()
        {
            Student student = new Student("Pesho", 100000);
        }
    }
}
