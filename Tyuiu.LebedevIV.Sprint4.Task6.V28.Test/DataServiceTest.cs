using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint4.Task6.V28.Lib;

namespace Tyuiu.LebedevIV.Sprint4.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var voda = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            var res = ds.Calculate(voda);
            string[] wait = { "Река", "Лужа", "Море" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
