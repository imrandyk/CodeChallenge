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

            if(vs.Length != 0)
            {
                for (int i = vs.Length - 1; i > 0; i--)
                {
                    var n = new ListNode(vs[i], child);
                    child = n;
                }

                this.val = vs[0];
                this.next = child;
            }
        }

        // insert new value at the start
        public void add(int val = 0, ListNode next = null)
        {
            next = new ListNode(val, next);
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
