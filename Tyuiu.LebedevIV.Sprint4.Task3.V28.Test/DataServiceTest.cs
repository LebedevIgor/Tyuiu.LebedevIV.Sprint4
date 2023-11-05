﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint4.Task3.V28.Lib;

namespace Tyuiu.LebedevIV.Sprint4.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {{5, 4, 9, 8, 5},
    {4, 6, 6, 9, 9},
    {9, 8, 4, 8, 8},
    {6, 8, 6, 8, 9},
    {9, 4, 6, 6, 7}   };
            int res = ds.Calculate(mas2);
            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
