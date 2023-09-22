namespace LeetCode
{
    public class AddTwoNumbers
    {
        /**
         * Definition for singly-linked list.     
         */
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
            int carryOne = 0;
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode value = new ListNode()
                {
                    val = l1.val + l2.val + carryOne
                };

                if (l1.val + l2.val + carryOne >= 10)
                {
                    carryOne = 1;
                    value.val = value.val - 10;
                }
                else
                    carryOne = 0;

                if (l1.next == null && l2.next != null)
                    l1.next = new ListNode(0);
                if (l2.next == null && l1.next != null)
                    l2.next = new ListNode(0);
                if (l1.next != null && l1.next != null)
                    value.next = AddTwoNumbers(l1.next, l2.next);
                if (l1.next == null && l2.next == null && carryOne == 1)
                    value.next = new ListNode(1, null);


                return value;

            }
        }
    }
}
