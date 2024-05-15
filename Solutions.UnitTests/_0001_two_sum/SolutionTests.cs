using Solutions._0001_two_sum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests._0001_two_sum
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        [DataRow(new int[]{ 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void Cases(int[] nums, int target, int[] expected)
        {
            Solution solution = new Solution();

            int[] output = solution.TwoSum(
                nums: nums,
                target: target
                );

            //assert output is of length 2
            Assert.AreEqual(2, output?.Length);

            HashSet<int> outputLookup = new HashSet<int>(output);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsTrue(outputLookup.Contains(expected[i]));
            }
        }
    }
}