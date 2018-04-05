using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var list = new List<int> { 1, 2, 3, 1, 10, 10 };
            var expected = 20;

            // act
            var actual = Program.LargestTwoElementConsecutiveSum(list);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
