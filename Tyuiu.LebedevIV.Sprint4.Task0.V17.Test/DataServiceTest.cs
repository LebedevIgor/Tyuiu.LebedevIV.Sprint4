using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint4.Task0.V17.Lib;

namespace Tyuiu.LebedevIV.Sprint4.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] numArray = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };
            int res = ds.GetSumEvenArrEl(numArray);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
