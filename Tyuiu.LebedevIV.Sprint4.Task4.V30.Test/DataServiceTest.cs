using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint4.Task4.V30.Lib;

namespace Tyuiu.LebedevIV.Sprint4.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {
            { 3, 4, 6, 6, 5 },
            { 6, 7, 6, 3, 5 },
            { 5, 3, 5, 7, 6 },
            { 6, 4, 7, 6, 6 },
            { 7, 4, 3, 4, 5 }
        };

            int[,] wait = new int[5, 5] {
            { 0, 4, 6, 6, 0 },
            { 6,0, 6, 0, 0 },
            { 0, 0, 0, 0, 6 },
            { 6, 4,0, 6, 6 },
            { 0, 4, 0, 4, 0 }
        };

            int[,] result = ds.Calculate(mas2);

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
