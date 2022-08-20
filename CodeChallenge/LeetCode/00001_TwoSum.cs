namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int f = 0;
            int s = 1;
            for (; f < nums.Length; f++)
            {
                for (; s < nums.Length; s++)
                {
                    if (nums[f] + nums[s] == target)
                    {
                        return new int[] { f, s };
                    }
                }
                s = f + 2;
            }
            return new int[] { f, s };
        }
    }
}
