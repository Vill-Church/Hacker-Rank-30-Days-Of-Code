using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Intro_to_Conditional_Statements
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 > 0)
            {
                Console.WriteLine("Weird");
            }
            else if (N < 6 || N > 20)
            {
                Console.WriteLine("Not Weird");
            }
            else
            {
                Console.WriteLine("Weird");
            }
        }
    }
}
