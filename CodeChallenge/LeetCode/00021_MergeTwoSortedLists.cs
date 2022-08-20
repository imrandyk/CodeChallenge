namespace CodeChallenge.LeetCode
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

        public ListNode(int[] vs)
        {
            ListNode child = null;
            for (int i = vs.Length-1; i > 0; i--)
            {
                var n = new ListNode(vs[i], child);
                child = n;
            }

            this.val = vs[0];
            this.next = child;
        }
    }

    partial class LeetCode
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1.val > list2.val)
            {
                (list2, list1) = (list1, list2);
            }

            var result = list1;
            
            while(list1.next != null && list2 != null)
            {
                if(list1.next.val < list2.val)
                {
                    list1 = list1.next;
                }
                else
                {
                    var temp1 = list1.next;
                    var temp2 = list2.next;
                    list1.next = list2;
                    list2.next = temp1;
                    list1 = list1.next;
                    list2 = temp2;
                }
            }

            if(list1.next == null)
            {
                list1.next = list2;
            }

            return result;
        }
    }
}
