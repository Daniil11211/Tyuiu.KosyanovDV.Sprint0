using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KosyanovDV.Sprint0.Task4.V0.Lib;


namespace Tyuiu.KosyanovDV.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void checkedAdditionValid()
        {
            Assert.AreEqual(35, DataService.Addition(18, 17));
        }
        public void checkedMultiplicationValid()
        {
            Assert.AreEqual(35, DataService.Multiplication(5, 7));
        }
        public void checkedSubstractionValid()
        {
            Assert.AreEqual(35, DataService.Substraction(36, 1));
        }
        public void checkedDivisionValid()
        {
            Assert.AreEqual(9, DataService.Division(18, 2));
        }

    }
}