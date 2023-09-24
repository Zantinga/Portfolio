//You are given two non-empty linked lists representing two non-negative integers.
//The digits are stored in reverse order, and each of their nodes contains a single digit.
//Add the two numbers and return the sum as a linked list.

//You may assume the two numbers do not contain any leading zero, except the number 0 itself.

using System.Runtime.CompilerServices;

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
                if (l1.next != null && l2.next != null)
                    value.next = AddTwoNumbers(l1.next, l2.next);
                if (l1.next == null && l2.next == null && carryOne == 1)
                    value.next = new ListNode(1);

                return value;
            }
        }

        public void execute()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("2. Add Two Numbers");
            Solution solution = new Solution();

            //Output: [7, 0, 8]
            var node1 = new ListNode(2, new ListNode (4, new ListNode(3)));
            var node2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var result = solution.AddTwoNumbers(node1, node2);
            printLinkedList(result);

            //Output: [0]
            node1 = new ListNode(0);
            node2 = new ListNode(0);

            result = solution.AddTwoNumbers(node1, node2);
            printLinkedList(result);

            //Output: [8,9,9,9,0,0,0,1]
            node1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            node2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

            result = solution.AddTwoNumbers(node1, node2);
            printLinkedList(result);
        }

        public void printLinkedList(ListNode node)
        {
            string result = node.val.ToString();
            ListNode newNode = node;

            while (newNode.next != null) { 
                result += ", " + newNode.next.val.ToString();
                newNode = newNode.next; 
            }
            Console.WriteLine("[{0}]", result);
        }
    }
}
