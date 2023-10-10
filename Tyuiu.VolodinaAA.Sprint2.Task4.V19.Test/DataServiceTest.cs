using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint2.Task4.V19.Lib;

namespace Tyuiu.VolodinaAA.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 11;
            double z = ds.Calculate(x, y);
            double wait = 6.033;
            Assert.AreEqual(wait, z);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 6;
            double z = ds.Calculate(x, y);
            double wait = 0.533;
            Assert.AreEqual(wait, z);
        }
    }
}
