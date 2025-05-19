namespace _1945._Sum_of_Digits_of_String_After_Convert
{
    internal class Program
    {
        static int GetLucky(string s, int k)
        {
            // Step 1: Convert string s to its letter positions and concatenate as string
            string res = string.Concat(s.Select(c => (c - 'a' + 1).ToString()));

            // Step 2: Transform the result k times
            for (int i = 0; i < k; i++)
            {
                int sum = 0;
                foreach (char digit in res)
                    sum += digit - '0';

                res = sum.ToString();
            }

            return int.Parse(res);
        }

        static void Main(string[] args)
        {
            int x = GetLucky("aaaa",1);
            Console.WriteLine(x);
        }
    }
    
}
