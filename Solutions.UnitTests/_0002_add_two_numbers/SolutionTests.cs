using Solutions._0002_add_two_numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests._0002_add_two_numbers
{
    [TestClass]
    public class SolutionTests
    {
        private ListNode _fromArray(int[] array)
        {
            ListNode node = new ListNode();

            ListNode current = node;

            for (int i = 0; i < array.Length; i++)
            {
                current.val = array[i];

                if(i < array.Length - 1)
                {
                    current.next = new ListNode();
                    current = current.next;
                }
            }

            return node;
        }

        [TestMethod]
        [DataRow(new int[]{ 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [DataRow(new int[] { 0 }, new int[] { 0 }, new int[] {0 })]
        [DataRow(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void Cases(int[] list1, int[] list2, int[] expected)
        {
            Solution solution = new Solution();

            ListNode output = solution.AddTwoNumbers(
                l1: _fromArray(list1),
                l2: _fromArray(list2)
                );

            ListNode current = output;
            for(int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], current.val);
                current = current.next;
            }
        }
    }
}