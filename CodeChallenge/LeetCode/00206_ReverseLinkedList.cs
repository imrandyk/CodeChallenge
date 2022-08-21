namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public ListNode ReverseList(ListNode head)
        {
            if(head == null)
                return head;

            ListNode temp = head;
            ListNode next = null;

            while(temp.next != null)
            {
                next = new ListNode(temp.val, next);
                temp = temp.next;
            }

            temp.next = next;

            return temp;
        }
    }
}
