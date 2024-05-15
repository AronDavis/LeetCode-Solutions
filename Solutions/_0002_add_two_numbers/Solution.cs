namespace Solutions._0002_add_two_numbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carryOver = 0;

            ListNode output = new ListNode();

            ListNode current = output;
            ListNode currentL1 = l1;
            ListNode currentL2 = l2;

            while (true)
            {
                int sum = carryOver;

                if (currentL1 != null)
                {
                    sum += currentL1.val;
                    currentL1 = currentL1.next;
                }

                if (currentL2 != null)
                {
                    sum += currentL2.val;
                    currentL2 = currentL2.next;
                }

                current.val = sum % 10;
                carryOver = sum / 10;

                if (currentL1 != null || currentL2 != null || carryOver > 0)
                {
                    current.next = new ListNode();
                    current = current.next;
                }
                else
                {
                    break;
                }
            }

            return output;
        }
    }
}