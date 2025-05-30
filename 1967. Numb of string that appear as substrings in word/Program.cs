namespace _1967._Numb_of_string_that_appear_as_substrings_in_word
{
    public static class Solution
    {
        public static int NumOfStrings(string[] patterns, string word)
        {
            int res = 0;
            for (int i=0; i<patterns.Length; i++)
            {
                if (word.Contains(patterns[i]))
                {
                    res++;
                }
            }
            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.NumOfStrings(["a", "abc", "bc", "d"], "abc") == 3);
            Console.WriteLine(Solution.NumOfStrings(["a", "b", "c"], "aaaaabbbbb") == 2);
        }
    }
}
