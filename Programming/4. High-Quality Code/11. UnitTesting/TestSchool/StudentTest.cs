using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolSystem;

namespace TestSchool
{
    [TestClass]
    public class StudentTest
    {
        // Student Name tests
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStudentName()
        {
            Student student = new Student(null, 12000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStudentName()
        {
            Student student = new Student("", 12000);
        }

        [TestMethod]
        public void OneLetterStudentName()
        {
            Student student = new Student("U", 12000);

            string result = student.Name;

            Assert.AreEqual("U", result);
        }

        [TestMethod]
        public void LongStudentName()
        {
            Student student = new Student("Thisstudenthaveuberduberlongname", 12000);

            string result = student.Name;

            Assert.AreEqual("Thisstudenthaveuberduberlongname", result);
        }

        // Student Id tests
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentIdJustBelowRange()
        {
            Student student = new Student("Marko", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentIdALotBelowRange()
        {
            Student student = new Student("Marko", int.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentIdJustAboveRange()
        {
            Student student = new Student("Marko", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentIdALotAboveRange()
        {
            Student student = new Student("Marko", int.MaxValue);
        }

        [TestMethod]
        public void StudentIdJustInLowerRange()
        {
            Student student = new Student("Marko", 10000);

            int result = student.IdNum;

            Assert.AreEqual(10000, result);
        }

        [TestMethod]
        public void StudentIdJustInHigherRange()
        {
            Student student = new Student("Marko", 99999);

            int result = student.IdNum;

            Assert.AreEqual(99999, result);
        }

        [TestMethod]
        public void StudentIdMiddleInRange()
        {
            Student student = new Student("Marko", 50000);

            int result = student.IdNum;

            Assert.AreEqual(50000, result);
        }
    }
}