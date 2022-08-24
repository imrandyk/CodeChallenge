namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public Node Preorder_TestObject1()
        {
            var root = new Node(1, new List<Node>
            {
                new Node(3, new List<Node> { new Node(5), new Node(6)}),
                new Node(2),
                new Node(4)
            });
            return root;
        }

        public Node Preorder_TestObject2()
        {
            var root = new Node(1, new List<Node>
            {
                new Node(2),
                new Node(3, new List<Node>
                {
                    new Node(6),
                    new Node(7, new List<Node>
                    {
                        new Node(11, new List<Node>
                        {
                            new Node(14)
                        }),
                    })
                }),
                new Node(4, new List<Node>
                {
                    new Node(8, new List<Node>
                    {
                        new Node(12),
                    }),
                }),
                new Node(5, new List<Node>
                {
                    new Node(9, new List<Node>
                    {
                        new Node(13)
                    }),
                    new Node(10)
                })
            });
            return root;
        }

        public IList<int> Preorder(Node root)
        {
            return Walk(root);
        }
        
        public IList<int> Walk(Node root)
        {
            var ret = new List<int>();

            if (root == null)
            {
                return ret;
            }

            ret.Add(root.val);
            if (root != null && root.children != null)
            {
                foreach (var child in root.children)
                {
                    ret.AddRange(Walk(child));
                }
            }
            return ret;
        }
    }
}
