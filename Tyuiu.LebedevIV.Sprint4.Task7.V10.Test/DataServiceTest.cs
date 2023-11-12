using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint4.Task7.V10.Lib;

namespace Tyuiu.LebedevIV.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "695847142536";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
