using System;
using System.Linq;

namespace Task04_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int lenght = numbers.Length;
            int helpIndex = lenght / 4 - 1;

            for (int i = (lenght / 4); i <= (lenght / 2 - 1); i++)
            {
                Console.Write($"{numbers[i] + numbers[helpIndex]} ");
                helpIndex--;
            }

            helpIndex = lenght - 1;
            for (int i = (lenght / 2); i <= (3 * lenght / 4 -1) ; i++)
            {
                Console.Write($"{numbers[i] + numbers[helpIndex]} ");
                helpIndex--;
            }
        }
    }
}
