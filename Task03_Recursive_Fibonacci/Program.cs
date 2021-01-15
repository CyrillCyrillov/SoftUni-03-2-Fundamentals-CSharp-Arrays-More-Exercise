using System;

namespace Task03_Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFibonacci = int.Parse(Console.ReadLine());

            int result = 1;
            int previous = 1;
            int previousPrevious = 1;
            if (numberOfFibonacci > 2)
            {
                for (int i = 3; i <= numberOfFibonacci; i++)
                {
                    result = previous + previousPrevious;
                    previousPrevious = previous;
                    previous = result;
                }
            }

            Console.WriteLine(result);
        }
    }
}
