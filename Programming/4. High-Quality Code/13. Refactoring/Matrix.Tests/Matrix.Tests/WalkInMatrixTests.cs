using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matrix.Tests
{
    [TestClass]
    public class WalkInMatrixTests
    {
        [TestMethod]
        [Timeout(1000)]
        public void TestSize1()
        {
            string expected = "  1\n";
            string actual = WalkInMatrix.WalkThroughMatrix(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Timeout(1000)]
        public void TestSize3()
        {
            string expected = "  1  7  8\n  6  2  9\n  5  4  3\n";
            string actual = WalkInMatrix.WalkThroughMatrix(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Timeout(1000)]
        public void TestSize6()
        {
            string expected = "  1 16 17 18 19 20\n 15  2 27 28 29 21\n 14 31  3 26 30 22\n 13 36 32  4 25 23\n 12 35 34 33  5 24\n 11 10  9  8  7  6\n";
            string actual = WalkInMatrix.WalkThroughMatrix(6);

            Assert.AreEqual(expected, actual);
        }
    }
}
