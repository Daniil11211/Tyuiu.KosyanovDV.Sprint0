using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosyanovDV.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KosyanovDV.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }



        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(10, DataService.Substraction(15, 5));
        }



        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(35, DataService.Multiplication(5, 7));
        }



        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(9, DataService.Division(18, 2));
        }
    }
}