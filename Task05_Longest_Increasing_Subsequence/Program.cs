using System;
using System.Linq;

namespace Task05_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int maxLength = 0;
            int lastIndex = -1;
            int[] len = new int[nums.Length];
            int[] previous = new int[nums.Length];

            for (int i = 0; i <= nums.Length-1; i++)
            {
                len[i] = 1;
                previous[i] = -1;

                for (int k = 0; k < i; k++)
                {
                    if (nums[k] < nums[i] && len[k] + 1 > len[i])
                    {
                        len[i] = len[k] + 1;
                        previous[i] = k;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            int[] longest = new int[maxLength];
            int currentIndex = maxLength - 1;

            while (lastIndex != -1)
            {
                longest[currentIndex] = nums[lastIndex];
                currentIndex--;
                lastIndex = previous[lastIndex];
            }

            Console.WriteLine(string.Join(" ", longest));
        }
    }
}
