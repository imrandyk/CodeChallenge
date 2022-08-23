using CodeChallenge.LeetCode;

namespace CodeChallenge
{
    public static class Log
    {
        public static void Title(string title)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
            Console.WriteLine(title.ToUpper());
            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
        }

        public static void Should(string result, string should)
        {
            Console.WriteLine($"{result} Should be: {should}");
        }

        public static void Should(bool result, string should)
        {
            Console.WriteLine($"{result} Should be: {should}");
        }

        public static void Should(int result, string should)
        {
            Console.WriteLine($"{result} Should be: {should}");
        }

        public static void Should(int[] result, string should)
        {
            Console.WriteLine($"[{string.Join(", ", result)}] Should be: {should}");
        }

        public static void Should(IList<int> result, string should)
        {
            Console.WriteLine($"[{string.Join(", ", result)}] Should be: {should}");
        }

        public static void Should(ListNode result, string should)
        {
            var n = result;
            var r = new List<int>();
            var cnt = 0;
            if(n != null)
            {
                while(n.next != null && cnt < 100)
                {
                    r.Add(n.val);
                    n = n.next;
                    cnt++;
                }
                r.Add(n.val);
            }
            Should(r.ToArray(), cnt == 100 ? $"{should} was repeating": should );
        }

        public static void Wait()
        {
            Console.ReadKey();
        }
    }
}
