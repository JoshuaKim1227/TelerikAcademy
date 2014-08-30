namespace UnitTestForTask4
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestForTask4
    {
        [TestMethod]
        public void TestMethod1()
        {
            NumberInArrayCount.numberToSearch = 0;
            NumberInArrayCount.arrayLength = 5;

            int[] array = new int[5] { 1, 0, 5, 7, 0 };

            int res = NumberInArrayCount.CountNumberInArray(array);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            NumberInArrayCount.numberToSearch = 5;
            NumberInArrayCount.arrayLength = 5;

            int[] array = new int[5] { 1, 3, 5, 7, 5 };

            int res = NumberInArrayCount.CountNumberInArray(array);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            NumberInArrayCount.numberToSearch = -23;
            NumberInArrayCount.arrayLength = 5;

            int[] array = new int[5] { -23, 3, 5, 7, 5 };

            int res = NumberInArrayCount.CountNumberInArray(array);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            NumberInArrayCount.numberToSearch = 1;
            NumberInArrayCount.arrayLength = 5;

            int[] array = new int[5] { 1, 1, 1, 1, 1 };

            int res = NumberInArrayCount.CountNumberInArray(array);

            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            NumberInArrayCount.numberToSearch = 0;
            NumberInArrayCount.arrayLength = 5;

            int[] array = new int[5] { -123, -1244, -151, 124124, 0 };

            int res = NumberInArrayCount.CountNumberInArray(array);

            Assert.AreEqual(1, res);
        }
    }
}