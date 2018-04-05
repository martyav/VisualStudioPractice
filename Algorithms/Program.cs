using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int RecursiveFactorial(int startingAt)
        {
            if (startingAt == 0)
            {
                return 1;
            }

            return startingAt * RecursiveFactorial(startingAt - 1);
        }

        public static String ReverseString(String text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return text;
            }

            return text[text.Count() - 1] + ReverseString(text.Substring(0, text.Count() - 1));
        }

        public static int LargestTwoElementConsecutiveSum(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException();
            }

            if (list.Count == 1) {
                return list[0];
            }

            if (list.Count == 2)
            {
                return list[1] + list[0];
            }

            var currentSum = 0;
            var biggestSum = 0;

            for (var i = 0; i < list.Count - 1; i++)
            {
                currentSum = list[i] + list[i + 1];

                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                }
            }

            return biggestSum;
        }
    }
}
