using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLargestTwoElementConsecutiveSum()
        {
            // arrange
            var list = new List<int> { 1, 2, 3, 1, 10, 10 };
            var expected = 20;

            // act
            var actual = Program.LargestTwoElementConsecutiveSum(list);

            // assert
            Assert.AreEqual(expected, actual);
        }

        public void TestRecursiveFactorial()
        {
            // arrange
            var startingAt = 5;
            var expected = 120;

            // act
            var actual = Program.RecursiveFactorial(startingAt);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
