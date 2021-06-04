using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator obj = new Calculator();
        [TestMethod]
        public void TestAdd()
        {
            int act = obj.add(2, 3);
            int exp = 5;
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void TestSub()
        {
            int act = obj.sub(15, 5);
            int exp = 10;
            Assert.AreEqual(exp, act);
        }
    }
}
