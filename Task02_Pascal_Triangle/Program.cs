using System;

namespace Task02_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int pascalLenght = 0;
            for (int i = 1 ; i <= lines; i++)
            {
                pascalLenght += i;
            }

            int[] pascalTriangle = new int[pascalLenght];
            int index = 0;

            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    if(j == 1 || j == i)
                    {
                        pascalTriangle[index] = 1;
                        index++;
                    }
                    else
                    {
                        pascalTriangle[index] = pascalTriangle[index - i] + pascalTriangle[index - i + 1];
                        index++;
                    }
                    
                    Console.Write($"{pascalTriangle[index - 1]} ");

                }

                Console.WriteLine();
            }
        }
    }
}
