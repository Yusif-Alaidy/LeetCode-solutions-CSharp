namespace _125._Valid_Palindrome
{
    using System.Text.RegularExpressions;

    public class Solution
    {
        public static bool IsPalindrome(string s)
        {
            // Remove non-alphanumeric characters and convert to lowercase
            string cleaned = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            // Use two pointers to check for palindrome
            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}
