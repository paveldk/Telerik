namespace StudentTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestToAddSchoolWithNullName()
        {
            School school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToAddSchoolWithEmptyName()
        {
            School school = new School(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToAddNullStudentInTheSchool()
        {
            School school = new School("Telerik");
            school.AddStudent(null);
        }

        [TestMethod]
        public void TestToGetTheNameOfSchool()
        {
            School school = new School("Telerik");
            string schoolName = school.Name;

            Assert.AreEqual("Telerik", schoolName, "When we get name of this school it should be Telerik, at least for this example");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToAddTwoStudentsWithSameUniqueNumbers()
        {
            School school = new School("Telerik");
            school.AddStudent(new Student("Pesho", 11111));
            school.AddStudent(new Student("Gosho", 11111));
        }
    }
}
