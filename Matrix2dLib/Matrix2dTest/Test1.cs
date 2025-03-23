using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix2dLibr;
using System;

namespace Matrix2dTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        // Sprawdzenie macierzy jednostkowej
        public void TestMacierzJednostkowa()
        {
            var identity = Matrix2d.Id;
            Assert.AreEqual(new Matrix2d(1, 0, 0, 1), identity);
        }

        [TestMethod]
        // Sprawdzenie zerowej macierzy
        public void TestMacierzZerowa()
        {
            var zero = Matrix2d.Zero;
            Assert.AreEqual(new Matrix2d(0, 0, 0, 0), zero);
        }

       
    }
}