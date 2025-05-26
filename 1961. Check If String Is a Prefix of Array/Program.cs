namespace _1961._Check_If_String_Is_a_Prefix_of_Array
{
    public class Solution
    {
        public bool IsPrefixString(string s, string[] words)
        {
            int currentIndex = 0;

            foreach (string word in words)
            {
                if (currentIndex + word.Length > s.Length)
                    return false;

                if (s.Substring(currentIndex, word.Length) != word)
                    return false;

                currentIndex += word.Length;

                if (currentIndex == s.Length)
                    return true;
            }

            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();            

            Console.WriteLine(s.IsPrefixString("a", ["aa", "aaaa", "banana"]));
        }
    }
}
