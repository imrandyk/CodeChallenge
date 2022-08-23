namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
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
