namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var f = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (f.Contains(nums[i]))
                    return true;
                f.Add(nums[i]);
            }
            return false;
        }

    }
}
