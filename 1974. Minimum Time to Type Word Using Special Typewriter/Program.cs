namespace _1974._Minimum_Time_to_Type_Word_Using_Special_Typewriter
{
    internal class Program
    {

        static int MinTimeToType(string word)
        {
            int res = 0;
            char cur = 'a';

            foreach (char c in word)
            {
                int dist = Math.Abs(c - cur);
                res += Math.Min(dist, 26 - dist) + 1; // movement time + typing
                cur = c;
            }

            return res;
            
        }
        static void Main(string[] args)
        {
            int x = MinTimeToType("abc");
            Console.WriteLine(x);
         
            
        }
    }
}
