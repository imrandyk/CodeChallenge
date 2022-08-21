namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public int MaxProfit(int[] prices)
        {
            int min = prices[0];
            int max = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                min = min < prices[i] ? min : prices[i];
                var diff = prices[i] - min;
                max = max < diff ? diff : max;
            }

            return max;
        }
    }
}
