using System;

namespace _344._Reverse_String
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            char[] input = { 'h', 'e', 'l', 'l', 'o' };
            solution.ReverseString(input);

            Console.WriteLine(new string(input)); // olleh
        }
    }
}
