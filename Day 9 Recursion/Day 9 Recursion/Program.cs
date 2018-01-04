using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Recursion
{
    class Program
    {
        static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = factorial(n);
            Console.WriteLine(result);
        }
    }
}
