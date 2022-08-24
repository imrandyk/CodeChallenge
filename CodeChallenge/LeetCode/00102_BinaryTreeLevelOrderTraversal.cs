namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public TreeNode LevelOrder_TestObject1()
        {
            var root = new TreeNode(
                3,
                new TreeNode(9),
                new TreeNode(
                    20,
                    new TreeNode(15),
                    new TreeNode(7)
                )
                );
            return root;
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var depth = Depth(root);
            var list = new List<IList<int>>();
            for (int i = 1; i <= depth; i++)
            {
                list.Add(GetLevel(root, i));
            }
            return list;
        }

        public int Depth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            
            var l = Depth(root.left);
            var r = Depth(root.right);

            if(l > r)
            {
                return l+1;
            }
            else
            {
                return r+1;
            }
        }

        public IList<int> GetLevel(TreeNode root = null, int level = 0)
        {
            if(root == null)
            {
                return null;
            }

            if(level == 1)
            {
                return new List<int> { root.val };
            }

            var list = new List<int>();
            var l = GetLevel(root.left, level - 1);
            if(l != null)
            {
                list.AddRange(l);
            }
            var r = GetLevel(root.right, level - 1);
            if (r != null)
            {
                list.AddRange(r);
            }
            return list;
        }
    }
}
