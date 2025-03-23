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
        [TestMethod]
        // Sprawdzenie dodawania macierzy
        public void TestDodawanie()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(5, 6, 7, 8);
            var result = m1 + m2;
            Assert.AreEqual(new Matrix2d(6, 8, 10, 12), result);
        }

        [TestMethod]
        // Sprawdzenie odejmowania macierzy
        public void TestOdejmowanie()
        {
            var m1 = new Matrix2d(5, 6, 7, 8);
            var m2 = new Matrix2d(1, 2, 3, 4);
            var result = m1 - m2;
            Assert.AreEqual(new Matrix2d(4, 4, 4, 4), result);
        }

        [TestMethod]
        // Sprawdzenie mnożenia macierzy
        public void TestMnozenie()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(2, 0, 1, 2);
            var result = m1 * m2;
            Assert.AreEqual(new Matrix2d(4, 4, 10, 8), result);
        }

        [TestMethod]
        // Sprawdzenie mnożenia macierzy przez skalar
        public void TestMnozeniePrzezSkalar()
        {
            var m = new Matrix2d(1, 2, 3, 4);
            var result = 2 * m;
            Assert.AreEqual(new Matrix2d(2, 4, 6, 8), result);
        }

        [TestMethod]
        // Sprawdzenie transpozycji macierzy
        public void TestTranspozycja()
        {
            var m = new Matrix2d(1, 2, 3, 4);
            var result = Matrix2d.Transpose(m);
            Assert.AreEqual(new Matrix2d(1, 3, 2, 4), result);
        }

        [TestMethod]
        // Sprawdzenie wyznacznika macierzy
        public void TestWyznacznik()
        {
            var m = new Matrix2d(1, 2, 3, 4);
            var result = m.Determinant();
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        // Sprawdzenie parsowania macierzy z ciągu znaków
        public void TestParsowanie()
        {
            var s = "[[1, 2], [3, 4]]";
            var result = Matrix2d.Parse(s);
            Assert.AreEqual(new Matrix2d(1, 2, 3, 4), result);
        }

        [TestMethod]
        // Sprawdzenie niepoprawnego parsowania macierzy z ciągu znaków
        [ExpectedException(typeof(FormatException))]
        public void TestNiepoprawneParsowanie()
        {
            var s = "[[1, 2] [3, 4]]";
            Matrix2d.Parse(s);
        }

        [TestMethod]
        // Sprawdzenie jawnej konwersji macierzy na tablicę
        public void TestJawnaKonwersja()
        {
            var m = new Matrix2d(1, 2, 3, 4);
            var array = (int[,])m;
            Assert.AreEqual(1, array[0, 0]);
            Assert.AreEqual(2, array[0, 1]);
            Assert.AreEqual(3, array[1, 0]);
            Assert.AreEqual(4, array[1, 1]);
        }

    }
}