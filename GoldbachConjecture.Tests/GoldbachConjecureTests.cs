using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoldbachConjecture.Tests
{
    [TestClass]
    public class GoldbachConjecureTests
    {
        private GoldbachConjecture goldbachConjecture ;

        [TestInitialize]
        public void Initialize()
        {
            goldbachConjecture = new GoldbachConjecture();
        }     
        
        [TestMethod]
        public void Test_5()
        {
            var result = goldbachConjecture.Result(5);
            Assert.AreEqual(2, result.Item1);
            Assert.AreEqual(3, result.Item2);

        }

        [TestMethod]
        public void Test_8()
        {
            var result = goldbachConjecture.Result(8);
            Assert.AreEqual(3, result.Item1);
            Assert.AreEqual(5, result.Item2);
        }

        [TestMethod]
        public void Test_12()
        {
            var result = goldbachConjecture.Result(12);
            Assert.AreEqual(5, result.Item1);
            Assert.AreEqual(7, result.Item2);
        }

        [TestMethod]
        public void Test_98996()
        {
            var result = goldbachConjecture.Result(98996);
            Assert.AreEqual(17, result.Item1);
            Assert.AreEqual(98979, result.Item2);
        }
    }
}
