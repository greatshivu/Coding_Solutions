using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/add-two-numbers/description/

namespace Challenges.Leet
{
    public class AddTwoNumbers_LinkedList
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode? firstNode = null;
            ListNode? currentNode = firstNode;
            var carryValue = 0;
            var digitVal = 0;
            var sum = 0;
            var listOutPut = new List<int>();
            do
            {
                var dig1 = l1?.val ?? 0;
                var dig2 = l2?.val ?? 0;

                //if(carryValue > 0 && l1 == null && l2 == null) break;
                sum = carryValue + dig1 + dig2;
                if (sum != 0)
                {
                    digitVal = sum % 10;
                    carryValue = sum / 10;
                }
                else
                {
                    digitVal = 0;
                    carryValue = 0;
                }
                if (firstNode == null)
                {
                    listOutPut.Add(digitVal);
                    firstNode = new ListNode(digitVal, null); // 7,
                    currentNode = firstNode;
                }
                else
                {
                    listOutPut.Add(digitVal);
                    currentNode.next = new ListNode(digitVal, null); // 7, 
                    currentNode = currentNode.next;
                }
                l1 = l1?.next;
                l2 = l2?.next;
            }
            while (l1 != null || l2 != null);
            if (carryValue > 0)
            {
                listOutPut.Add(digitVal);
                currentNode.next = new ListNode(carryValue, null); // 7, 
                currentNode = currentNode.next;
            }
            return firstNode;
        }

        public ListNode? GetList(int[] values)
        {
            if (values == null || values.Length == 0) return null;
            ListNode? firstNode = new();
            ListNode? currentNode = firstNode;
            for (int i = 0; i < values.Length; i++)
            {
                int val = values[i];
                if (i == 0)
                {
                    firstNode.val = val;
                    currentNode = firstNode;
                    continue;
                }
                else
                {
                    currentNode.next = new ListNode(val);
                    currentNode = currentNode.next;
                }
            }
            return firstNode;
        }

        public int[] GetvaluesFromNode(ListNode? node)
        {
            if (node == null) return [];
            var result = new List<int>();

            do
            {
                result.Add(node.val);
                node = node.next;
            }
            while (node != null);
            return result.ToArray();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
