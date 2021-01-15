using System;
using System.Linq;

namespace Task05_Longest_Increasing_Subsequence_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int arraysLenght = numbers.Length;

            int[] lIS = new int[arraysLenght];
            int[] tempLIS = new int[arraysLenght];
            int indexToComparison = 0;
            int endIndex = 0;

            for (int i = 0; i <= arraysLenght - 1; i++)
            {
                tempLIS[0] = numbers[i];
                indexToComparison = 0;
                for (int j = i + 1; j <= arraysLenght - 1 ; j++)
                {
                    if(numbers[j] > tempLIS[indexToComparison])
                    {
                        tempLIS[indexToComparison + 1] = numbers[j];
                        indexToComparison++;
                    }
                }

                if(indexToComparison > endIndex)
                {
                    for (int x = 0; x <= indexToComparison; x++)
                    {
                        lIS[x] = tempLIS[x];
                        tempLIS[x] = 0;
                    }
                }
            }

            for (int i = 0; i <= indexToComparison; i++)
            {
                Console.Write($"{lIS[i]} ");
            }
        }
    }
}
