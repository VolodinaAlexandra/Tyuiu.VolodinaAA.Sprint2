using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint2.Task2.V14.Lib;

namespace Tyuiu.VolodinaAA.Sprint2.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 8;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
