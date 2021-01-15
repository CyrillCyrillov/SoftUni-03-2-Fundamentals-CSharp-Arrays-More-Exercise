using System;
using System.Linq;

namespace _Task01_Encrypt_Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameNumber = int.Parse(Console.ReadLine());
            
            int[] codeNames = new int[nameNumber];
            
           
            for (int i = 0; i < nameNumber; i++)
            {
                string name = Console.ReadLine();
                
                int vowelSum = 0;
                int consonantSum = 0;
                string vowelLetters = "AaEeOoIiUu";
                for (int j = 0; j < name.Length; j++)
                {
                    char nextLetter = name[j];
                    if (vowelLetters.Contains(nextLetter))
                    {
                        vowelSum += nextLetter * name.Length;
                    }
                    else
                    {
                        consonantSum += nextLetter / name.Length;
                    }
                }
                codeNames[i] = vowelSum + consonantSum;
            }

            Array.Sort(codeNames);

            for (int i = 0; i < nameNumber; i++)
            {
                Console.WriteLine(codeNames[i]);
            }
        }
    }
}
