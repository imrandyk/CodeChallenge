namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0)
                return true;

            var idx = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (s[idx] == t[i])
                {
                    idx++;
                }
                if (idx == s.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


