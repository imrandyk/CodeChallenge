namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public ListNode MiddleNode(ListNode head)
        {
            var d = 0;
            var t = head;
            while (t.next != null)
            {
                d++;
                t = t.next;
            }
            t = head;

            d = d % 2 == 0 ? d / 2 : (d + 1) / 2;

            for (var i = 0; i < d; i++)
                t = t.next;

            return t;
        }
    }
}
