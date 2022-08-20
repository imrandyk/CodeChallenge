namespace CodeChallenge
{
    public static class Log
    {
        public static void Should(string result, string should)
        {
            Console.WriteLine($"{result} Should be: {should}");
        }
        public static void Should(int[] result, string should)
        {
            Console.WriteLine($"{String.Join(", ", result)} Should be: {should}");
        }

        public static void Wait()
        {
            Console.ReadKey();
        }
    }
}
