using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        string result = NamePrinter.NamePrint(NamePrinter.GetInput());
        Assert.AreEqual("Nikolay", result);
    }
}

