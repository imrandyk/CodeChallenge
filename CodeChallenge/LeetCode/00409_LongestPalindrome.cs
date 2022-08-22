namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public int LongestPalindrome(string s)
        {
            var l = s.Length;
            if (l <= 1)
                return l;

            var dict = new HashSet<char>(s.ToCharArray()).ToDictionary(x => x, x => 0);

            for (int i = 0; i < l; i++)
            {
                dict[s[i]] = dict[s[i]] + 1;
            }

            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            var list = string.Join(Environment.NewLine, dict.Select(x => $"{x.Key}: {x.Value}").ToList());
            var singleFound = false;
            var result = 0;

            for (int i = 0; i < dict.Count; i++)
            {
                var c = dict.ElementAt(i);
                if (c.Value % 2 == 1 && !singleFound)
                {
                    singleFound = true;
                    result += c.Value;
                }
                else if (c.Value % 2 == 1 && singleFound)
                {
                    result += c.Value - 1;
                }
                else if (c.Value % 2 == 0)
                {
                    result += c.Value;
                }
            }

            return result;
        }
    }
}
