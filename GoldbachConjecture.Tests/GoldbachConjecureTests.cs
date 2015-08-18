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
    }
}
