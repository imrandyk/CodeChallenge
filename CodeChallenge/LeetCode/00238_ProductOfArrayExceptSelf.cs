namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return nums;

            var l = nums.Length;
            var prefix = 1;
            var suffix = 1;
            var res = Enumerable.Repeat(1, l).ToArray(); ;

            for (int i = 0; i < l; i++)
            {
                res[i] *= prefix;
                prefix *= nums[i];
                res[l - i - 1] *= suffix;
                suffix *= nums[l - i - 1];
            }
            return res;
        }
    }
}
