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

        public static void Should(int result, string should)
        {
            Console.WriteLine($"{result} Should be: {should}");
        }

        public static void Should(int[] result, string should)
        {
            Console.WriteLine($"[{string.Join(", ", result)}] Should be: {should}");
        }

        public static void Should(ListNode result, string should)
        {
            var n = result;
            var r = new List<int>();
            if(n != null)
            {
                while(n.next != null)
                {
                    r.Add(n.val);
                    n = n.next;
                }
                r.Add(n.val);
            }
            Should(r.ToArray(), should);
        }

        public static void Wait()
        {
            Console.ReadKey();
        }
    }
}
