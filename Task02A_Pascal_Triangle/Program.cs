using System;

namespace Task02A_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int numberOfElements = 0;

            for (int i = 0; i <= lines; i++)
            {
                numberOfElements += i;
            }

            int[] pasclaTriangle = new int[numberOfElements];


            
            Console.WriteLine("Hello World!");
        }
    }
}
