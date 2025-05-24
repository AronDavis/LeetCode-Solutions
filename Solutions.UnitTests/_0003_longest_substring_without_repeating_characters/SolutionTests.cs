using Solutions._0003_longest_substring_without_repeating_characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests._0003_longest_substring_without_repeating_characters
{
    [TestClass]
    public class SolutionTests
    {

        [TestMethod]
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 3)]
        [DataRow("aab", 2)]
        [DataRow("dvdf", 3)]
        [DataRow(" ", 1)]
        [DataRow("hijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789hijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789hijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789hijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789hijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789hijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 55)]
        public void Cases(string input, int expected)
        {
            Solution solution = new Solution();

            int result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(expected, result);
        }
    }
}