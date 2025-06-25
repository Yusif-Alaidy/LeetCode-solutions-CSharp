namespace _168._Excel_Sheet_Column_Title
{
    public class Solution
    {
        public string ConvertToTitle(int columnNumber)
        {
            string res = "";
            while (columnNumber>26)
            {
                if (columnNumber % 26 == 0)
                {
                    columnNumber --;
                    res = Convert.ToChar((columnNumber % 26 + 65)) + res;
                    columnNumber /= 26;
                }
                else
                {
                    res = Convert.ToChar((columnNumber % 26 + 64)) + res;
                    columnNumber /= 26;
                }
            }
            res = Convert.ToChar((columnNumber+64)) + res;
            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            //Console.WriteLine(solution.ConvertToTitle(701)); // ZY | 2625 
            //Console.WriteLine(solution.ConvertToTitle(702)); // ZZ | 2625 
            //Console.WriteLine(solution.ConvertToTitle(27)); // AA | 11 
            //Console.WriteLine(solution.ConvertToTitle(1)); // A | 1 
            //Console.WriteLine(solution.ConvertToTitle(28)); // AB | 12 
            //Console.WriteLine(solution.ConvertToTitle(52)); // AZ | 126 
            Console.WriteLine(solution.ConvertToTitle(18278)); // ZZZ | 126 

      
        }
    }
}
