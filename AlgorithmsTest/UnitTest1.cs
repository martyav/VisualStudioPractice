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

        [TestMethod]
        public void TestReverseString()
        {
            // arrange
            var text = "Hello";
            var expected = "olleH";

            // act
            var actual = Program.ReverseString(text);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSum()
        {
            // arrange
            var min = 0;
            var max = 5;
            var expected = 1 + 2 + 3 + 4 + 5;

            // act 
            var actual = Program.GetSum(min, max);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRecursivePower()
        {
            // arrange
            var x = 2;
            var y = 3;
            var expected = 8;

            // act
            var actual = Program.XToTheYPower(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyList()
        {
            // arrange
            var list = new List<int> { 1, 2, 3, 4 };
            var expected = 1 * 2 * 3 * 4;

            // act
            var actual = Program.MultiplyList(list);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
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
