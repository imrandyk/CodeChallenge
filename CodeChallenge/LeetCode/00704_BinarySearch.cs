namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public int Search(int[] nums, int target)
        {
            var step = (nums.Length -0) / 2;
            var index = 0 + step;

            if (nums.Length == 1 && nums[0] == target)
                return 0;

            for (int i = 0; i <= nums.Length / 2; i++)
            {
                if (index < 0 || index >= nums.Length)
                    return -1;

                if (nums[index] == target)
                    return index;

                step /= 2;
                if (step == 0)
                    step++;
                index += nums[index] > target ? -1 * step : step;
            }
            return -1;
        }
    }
}