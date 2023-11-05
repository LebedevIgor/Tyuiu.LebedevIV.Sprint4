using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint4.Task2.V8.Lib;

namespace Tyuiu.LebedevIV.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numArray = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7 };
            int res = ds.Calculate(numArray);
            int wait = 42;
            Assert.AreEqual(wait, res);
        }
    }
}
