using _88._Merge_Sort_Array.MergeSortArray;

namespace _88._Merge_Sort_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 3, m = 3, count = 0;
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int[] nums2 = [2, 5, 6];
            for (int i = n; i < nums1.Length; i++)
            {

                nums1[i] = nums2[count++];
                for (int j = i; j > 0; j--)
                {
                    if (nums1[j] < nums1[j - 1])
                    {
                        // swap 
                        int swap = nums1[j];
                        nums1[j] = nums1[j - 1];
                        nums1[j - 1] = swap;
                    }
                    else
                    {
                        break;
                    }
                }
            }


            Console.WriteLine(string.Join("", nums1)); // 1,2,2,3,5,6
        }

    }
    }
}
