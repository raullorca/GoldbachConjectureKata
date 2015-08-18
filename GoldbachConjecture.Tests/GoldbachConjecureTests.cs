using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GoldbachConjecture.Tests
{
    [TestClass]
    public class GoldbachConjecureTests
    {
        private GoldbachConjecture goldbachConjecture;

        [TestInitialize]
        public void Initialize()
        {
            goldbachConjecture = new GoldbachConjecture();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_1()
        {
            goldbachConjecture.Result(1);
        }

        [TestMethod]
        public void Test_12()
        {
            var result = goldbachConjecture.Result(12);
            Assert.AreEqual(5, result.Item1);
            Assert.AreEqual(7, result.Item2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_5()
        {
            goldbachConjecture.Result(5);
        }

        [TestMethod]
        public void Test_8()
        {
            var result = goldbachConjecture.Result(8);
            Assert.AreEqual(3, result.Item1);
            Assert.AreEqual(5, result.Item2);
        }

        [TestMethod]
        public void Test_98996()
        {
            var result = goldbachConjecture.Result(98996);
            Assert.AreEqual(3, result.Item1);
            Assert.AreEqual(98993, result.Item2);
        }
    }
}