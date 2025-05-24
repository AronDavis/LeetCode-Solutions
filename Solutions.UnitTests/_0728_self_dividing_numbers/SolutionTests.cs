using Solutions._0728_self_dividing_numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests._0728_self_dividing_numbers
{
    [TestClass]
    public class SolutionTests
    {

        [TestMethod]
        [DataRow(1, 22, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 })]
        [DataRow(47, 85, new int[] { 48, 55, 66, 77 })]
        public void Cases(int left, int right, int[] expected)
        {
            Solution solution = new Solution();

            IList<int> result = solution.SelfDividingNumbers(left, right);

            Assert.AreEqual(expected.Length, result.Count);

            for(int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}