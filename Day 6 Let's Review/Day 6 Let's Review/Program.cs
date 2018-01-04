using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Let_s_Review
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Int16.Parse(Console.ReadLine());
            for (int x = 0; x < n; x++)
            {
                String word = Console.ReadLine();
                for (int i = 0; i < word.Length; i += 2)
                {
                    Console.Write(word[i]);
                }
                Console.Write(" ");
                for (int j = 1; j < word.Length; j += 2)
                {
                    Console.Write(word[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
